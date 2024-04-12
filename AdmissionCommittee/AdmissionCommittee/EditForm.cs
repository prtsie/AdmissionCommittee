using System.ComponentModel.DataAnnotations;
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
            formOfEducationComboBox.AddBindings(comboBox => comboBox.SelectedItem, Applicant, applicant => applicant.FormOfEducation, errorProvider);
            genderComboBox.AddBindings(comboBox => comboBox.SelectedItem, Applicant, applicant => applicant.Gender, errorProvider);
            nameTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Name, errorProvider);
            surnameTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Surname, errorProvider);
            patronymicTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Patronymic, errorProvider);
            birthDateTimePicker.AddBindings(datePicker => datePicker.Value, Applicant, Applicant => Applicant.BirthDay, errorProvider);
            mathScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, Applicant => Applicant.MathScore, errorProvider);
            russianScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, Applicant => Applicant.RussianScore, errorProvider);
            ITScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, clone => clone.ITScore, errorProvider);
        }

        private void saveButton_Click(object _, EventArgs __)
        {
            var context = new ValidationContext(Applicant);
            var results = new List<ValidationResult>();
            if (Validator.TryValidateObject(Applicant, context, results))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("Не все поля корректны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
