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
            formOfEducationComboBox.DataSource = Enum.GetValues(typeof(FormOfEducation));
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            nameTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Name);
            surnameTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Surname);
            patronymicTextBox.AddBindings(textBox => textBox.Text, Applicant, Applicant => Applicant.Patronymic!);
            birthDateTimePicker.AddBindings(datePicker => datePicker.Value, Applicant, Applicant => Applicant.BirthDay);
            //formOfEducationComboBox.AddBindings(comboBox => comboBox.SelectedValue, Applicant!, Applicant => Applicant.FormOfEducation);
            //genderComboBox.AddBindings(comboBox => comboBox.SelectedValue, Applicant!, Applicant => Applicant.Gender);
            mathScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, Applicant => Applicant.MathScore);
            russianScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, Applicant => Applicant.RussianScore);
            ITScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, Applicant, clone => clone.ITScore);
        }
    }
}
