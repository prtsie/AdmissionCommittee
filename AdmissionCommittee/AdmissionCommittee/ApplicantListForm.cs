using AdmissionCommittee.Models;

namespace AdmissionCommittee
{
    public partial class ApplicantListForm : Form
    {
        private List<Applicant> data = new();

        public ApplicantListForm()
        {
            InitializeComponent();
            GenerateData(30);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = data;
            dataGridView.DataSource = bindingSource;
        }

        private void GenerateData(int count)
        {
            var random = new Random();
            var formOfEducationValues = Enum.GetValues<FormOfEducation>();
            var genderValues = Enum.GetValues<Gender>();
            var now = DateTime.Now;
            var minAge = 18;
            var maxAge = 21;
            string[] names = ["Алёша", "Вася", "Иннокентий", "Олег", "Доброгей", "Даздраперма", "Наруто"];
            string[] surnames = ["Иванов", "Каерчывпак", "Абдулгаджиев"];
            string[] patronymics = ["Магомедович", "Валентинович", "Евсеевич", "Аыуыаеич"];
            for (var i = 0; i < count; i++)
            {
                var year = random.Next(now.Year - maxAge, now.Year - minAge + 1);
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
    }
}
