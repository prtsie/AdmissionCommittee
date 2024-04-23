using System.Linq.Expressions;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

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
        /// <param name="value"></param>
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
    }
}
