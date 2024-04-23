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

            formOfEducationComboBox.AddBindings(x => x.SelectedItem, Applicant, x => x.FormOfEducation);
            genderComboBox.AddBindings(x => x.SelectedItem, Applicant, x => x.Gender);
            nameTextBox.AddBindings(x => x.Text, Applicant, x => x.Name, errorProvider1);
            surnameTextBox.AddBindings(x => x.Text, Applicant, x => x.Surname, errorProvider1);
            patronymicTextBox.AddBindings(x => x.Text, Applicant, x => x.Patronymic, errorProvider1);
            birthDateTimePicker.AddBindings(x => x.Value, Applicant, x => x.BirthDay, errorProvider1);
            mathScoreNumericUpDown.AddBindings(x => x.Value, Applicant, x => x.MathScore, errorProvider1);
            russianScoreNumericUpDown.AddBindings(x => x.Value, Applicant, x => x.RussianScore, errorProvider1);
            ITScoreNumericUpDown.AddBindings(x => x.Value, Applicant, x => x.ITScore, errorProvider1);
        }

        private void saveButton_Click(object _, EventArgs __)
        {
            var context = new ValidationContext(Applicant);
            var results = new List<ValidationResult>();
            if (Validator.TryValidateObject(Applicant, context, results, true))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("Не все поля корректны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
