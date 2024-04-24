using System.Linq.Expressions;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using AdmissionCommittee.Models;

namespace AdmissionCommittee
{
    static internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ApplicantListForm());
        }

        /// <summary>Возвращает <see cref="DisplayAttribute.Name"/> у члена <paramref name="memberName"/> типа <paramref name="type"/></summary>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static string GetMemberDisplayName(Type type, string memberName)
        {
            var member = type.GetMember(memberName).FirstOrDefault() ?? throw new NullReferenceException();
            var attributes = member.GetCustomAttributes(typeof(DisplayAttribute)).Cast<DisplayAttribute>();
            foreach (var attribute in attributes)
            {
                if (attribute.Name != null)
                {
                    return attribute.Name;
                }
            }
            throw new InvalidOperationException(!attributes.Any() ? "У значения нет атрибута Display" : "У атрибута Display не задано свойство Name");
        }
    }
}
