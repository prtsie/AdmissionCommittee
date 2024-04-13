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
            Applicant = applicant == null ? new Applicant { BirthDay = DateTime.Now } : (Applicant)applicant.Clone();
            formOfEducationComboBox.Items.AddRange(Enum.GetValues<FormOfEducation>().Cast<object>().ToArray());
            genderComboBox.Items.AddRange(Enum.GetValues<Gender>().Cast<object>().ToArray());
            formOfEducationComboBox.AddBindings(comboBox => comboBox.SelectedItem, Applicant, applicant => applicant.FormOfEducation);
            genderComboBox.AddBindings(comboBox => comboBox.SelectedItem, Applicant, applicant => applicant.Gender);
            nameTextBox.AddBindings(textBox => textBox.Text, Applicant, applicant => applicant.Name, errorProvider);
            surnameTextBox.AddBindings(textBox => textBox.Text, Applicant, applicant => applicant.Surname, errorProvider);
            patronymicTextBox.AddBindings(textBox => textBox.Text, Applicant, applicant => applicant.Patronymic, errorProvider);
            birthDateTimePicker.AddBindings(datePicker => datePicker.Value, Applicant, applicant => applicant.BirthDay);
            mathScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, applicant => applicant.MathScore, errorProvider);
            russianScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, applicant => applicant.RussianScore, errorProvider);
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
