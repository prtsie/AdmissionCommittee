using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Helpers
{
    /// <summary>Метод расширения для <see cref="Control"/></summary>
    static internal class ControlExtensions
    {
        /// <summary>Привязка лямбда-выражениями</summary>
        /// <typeparam name="TControl"></typeparam>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="control"></param>
        /// <param name="targetMember">Член для привязки</param>
        /// <param name="source">Источник привязки</param>
        /// <param name="sourceMember">Свойство источника для привязки</param>
        /// <param name="errorProvider"></param>
        public static void AddBindings<TControl, TSource>(this TControl control,
            Expression<Func<TControl, object?>> targetMember,
            TSource source,
            Expression<Func<TSource, object?>> sourceMember,
            ErrorProvider? errorProvider = null)
            where TControl : Control
            where TSource : class
        {
            var sourceMemberName = GetMemberName(sourceMember);
            var binding = new Binding(GetMemberName(targetMember), source, sourceMemberName)
            {
                DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged
            };
            control.DataBindings.Add(binding);

            if (errorProvider != null)
            {
                var sourcePropertyInfo = source.GetType().GetProperty(sourceMemberName);
                var validationAttributes = sourcePropertyInfo?.GetCustomAttributes<ValidationAttribute>();
                if (validationAttributes?.Any() == true)
                {
                    control.Validating += (o, args) =>
                    {
                        var context = new ValidationContext(source);
                        var results = new List<ValidationResult>();
                        errorProvider.SetError(control, string.Empty);
                        if (!Validator.TryValidateObject(source, context, results, true))
                        {
                            foreach (var error in results.Where(x => x.MemberNames.Contains(sourceMemberName)))
                            {
                                errorProvider.SetError(control, error.ErrorMessage);
                            }
                        }
                    };
                }
            }
        }

        private static string GetMemberName<TItem, TMember>(Expression<Func<TItem, TMember>> targetMember)
        {
            if (targetMember.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }
            if (targetMember.Body is UnaryExpression unaryExpression)
            {
                var op = unaryExpression.Operand;
                return ((MemberExpression)op).Member.Name;
            }
            throw new ArgumentException("Expression must be a member of unary expression");
        }

    }
}
