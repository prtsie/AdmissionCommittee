using AdmissionCommittee.Helpers;
using AdmissionCommittee.Models;

namespace AdmissionCommittee
{
    public partial class ApplicantListForm : Form
    {
        private readonly List<Applicant> data = new();
        public BindableBool IsSelected { get; private set; } = new();
        private Applicant? selected;
        private readonly BindingSource bindingSource;

        public ApplicantListForm()
        {
            InitializeComponent();
            GenerateData(5);
            bindingSource = new BindingSource
            {
                DataSource = data
            };
            dataGridView.DataSource = bindingSource;
            editButton.AddBindings(target => target.Enabled, IsSelected, source => source.Value);
            deleteButton.AddBindings(target => target.Enabled, IsSelected, source => source.Value);
        }

        private void GenerateData(int count)
        {
            var random = new Random();
            var formOfEducationValues = Enum.GetValues<FormOfEducation>();
            var genderValues = Enum.GetValues<Gender>();
            var now = DateTime.Now;
            string[] names = ["Алёша", "Вася", "Иннокентий", "Олег", "Доброгей", "Даздраперма", "Наруто"];
            string[] surnames = ["Иванов", "Каерчывпак", "Абдулгаджиев"];
            string[] patronymics = ["Магомедович", "Валентинович", "Евсеевич", "Аыуыаеич"];
            for (var i = 0; i < count; i++)
            {
                var year = random.Next(now.Year - ApplicantConstraints.MaxAge, now.Year - ApplicantConstraints.MinAge + 1);
                var month = random.Next(1, 12 + 1);
                var day = random.Next(1, DateTime.DaysInMonth(year, month));
                var applicant = new Applicant
                {
                    Name = names[random.Next(names.Length)],
                    Surname = surnames[random.Next(surnames.Length)],
                    Patronymic = patronymics[random.Next(patronymics.Length)],
                    BirthDay = new DateTime(year, month, day),
                    FormOfEducation = formOfEducationValues[random.Next(formOfEducationValues.Length)],
                    Gender = genderValues[random.Next(genderValues.Length)],
                    ITScore = random.Next(101),
                    RussianScore = random.Next(101),
                    MathScore = random.Next(101),
                };
                data.Add(applicant);
            }
        }

        private void dataGridView_SelectionChanged(object _, EventArgs __)
        {
            selected = dataGridView.SelectedRows.Count != 0 ? dataGridView.SelectedRows[0].DataBoundItem as Applicant : null;
            IsSelected.Value = selected != null;
        }

        private void deleteButton_Click(object _, EventArgs __)
        {
            var result = MessageBox.Show("Точно удалить?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bindingSource.Remove(selected);
            }
        }

        private void editButton_Click(object _, EventArgs __)
        {
            var editForm = new EditForm(selected);
            var result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bindingSource.Add(editForm.Applicant);
                bindingSource.Remove(selected);
            }
        }

        private void AddButton_Click(object _, EventArgs __)
        {
            var editForm = new EditForm();
            var result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                bindingSource.Add(editForm.Applicant);
            }
        }
    }
}
