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

        /// <summary>���������� <see cref="DisplayAttribute.Name"/> ��� �������� <see cref="Enum"></see></summary>
        /// <exception cref="InvalidOperationException"></exception>
        public static string GetEnumDisplayName(Enum value)
        {
            var attributes = value.GetType().GetField(value.ToString())!.GetCustomAttributes(typeof(DisplayAttribute)).Cast<DisplayAttribute>();
            foreach (var attribute in attributes)
            {
                if (attribute.Name != null)
                {
                    return attribute.Name;
                }
            }
            throw new InvalidOperationException(!attributes.Any() ? "� �������� ��� �������� Display" : "� �������� Display �� ������ �������� Name");
        }

        /// <summary>���������� <see cref="DisplayAttribute.Name"/> � �������� <paramref name="propertyName"/> ���� <paramref name="type"/></summary>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static string GetPropertyDisplayName(Type type, string propertyName)
        {
            var property = type.GetProperty(propertyName) ?? throw new NullReferenceException();
            var attributes = property.GetCustomAttributes(typeof(DisplayAttribute)).Cast<DisplayAttribute>();
            foreach (var attribute in attributes)
            {
                if (attribute.Name != null)
                {
                    return attribute.Name;
                }
            }
            throw new InvalidOperationException(!attributes.Any() ? "� �������� ��� �������� Display" : "� �������� Display �� ������ �������� Name");
        }
    }
}
