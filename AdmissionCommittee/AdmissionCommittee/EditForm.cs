using AdmissionCommittee.Helpers;
using AdmissionCommittee.Models;

namespace AdmissionCommittee
{
    public partial class EditForm : Form
    {
        public Applicant Applicant { get; private set; }
        public EditForm(Applicant? applicant = null)
        {
            InitializeComponent();
            if (applicant == null)
            {
                Applicant = new Applicant
                {
                    BirthDay = DateTime.Now
                };
            }
            else
            {
                Applicant = (Applicant)applicant.Clone();
            }
            formOfEducationComboBox.Items.AddRange(Enum.GetValues<FormOfEducation>().Cast<object>().ToArray());
            genderComboBox.Items.AddRange(Enum.GetValues<Gender>().Cast<object>().ToArray());
            formOfEducationComboBox.AddBindings(comboBox => comboBox.SelectedItem, Applicant, applicant => applicant.FormOfEducation);
            genderComboBox.AddBindings(comboBox => comboBox.SelectedItem, Applicant, applicant => applicant.Gender);
            nameTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Name);
            surnameTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Surname);
            patronymicTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Patronymic);
            birthDateTimePicker.AddBindings(datePicker => datePicker.Value, Applicant, Applicant => Applicant.BirthDay);
            mathScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, Applicant => Applicant.MathScore);
            russianScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, Applicant => Applicant.RussianScore);
            ITScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, clone => clone.ITScore);
        }
    }
}
