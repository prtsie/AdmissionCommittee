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
            Applicant? clone;
            if (applicant == null)
            {
                clone = new Applicant
                {
                    BirthDay = DateTime.Now
                };
            }
            else
            {
                clone = (Applicant)applicant.Clone();
            }

            formOfEducationComboBox.DataSource = Enum.GetValues(typeof(FormOfEducation));
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            nameTextBox.AddBindings(textBox => textBox.Text, clone!, clone => clone.Name);
            surnameTextBox.AddBindings(textBox => textBox.Text, clone!, clone => clone.Surname);
            patronymicTextBox.AddBindings(textBox => textBox.Text, clone!, clone => clone.Patronymic!);
            birthDateTimePicker.AddBindings(datePicker => datePicker.Value, clone!, clone => clone.BirthDay);
            //formOfEducationComboBox.AddBindings(comboBox => comboBox.SelectedValue, clone!, clone => clone.FormOfEducation);
            //genderComboBox.AddBindings(comboBox => comboBox.SelectedValue, clone!, clone => clone.Gender);
            mathScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, clone!, clone => clone.MathScore);
            russianScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, clone!, clone => clone.RussianScore);
            ITScoreNumericUpDown.AddBindings(numericUpDown => numericUpDown.Value, clone!, clone => clone.ITScore);
        }
    }
}
