using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using AdmissionCommittee.DB;
using AdmissionCommittee.Helpers;
using AdmissionCommittee.Models;
using AdmissionCommittee.Properties;

namespace AdmissionCommittee
{
    /// <summary>Форма со списком абитуриентов</summary>
    public partial class ApplicantListForm : Form
    {
        private const int ScoreThreshold = 150;
        private const int CalendarMargin = 3;
        private readonly BindingList<Applicant> data;
        private Applicant selected = null!;
        private readonly BindingSource bindingSource = new();
        private readonly Bitmap calendarImage = Resources.calendar;

        public ApplicantListForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            using var context = new CommitteeContext();
            if (!context.Applicants.AsNoTracking().Any())
            {
                context.Applicants.AddRange(DataGenerator.GenerateApplicants(10));
                context.SaveChanges();
            }
            data = new(context.Applicants.AsNoTracking().ToList());
            CalculateScores();
            data.ListChanged += (o, args) => CalculateScores();
            bindingSource.DataSource = data;
            dataGridView.DataSource = bindingSource;
        }

        private void CalculateScores()
        {
            applicantsCount.Text = data.Count(applicant => applicant.TotalScore >= ScoreThreshold).ToString();
        }

        private void dataGridView_SelectionChanged(object _, EventArgs __)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                selected = (Applicant)dataGridView.SelectedRows[0].DataBoundItem;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else
            {
                selected = null!;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }

        }

        private async void deleteButton_Click(object _, EventArgs __)
        {
            var result = MessageBox.Show("Точно удалить?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using var context = new CommitteeContext();
                context.Applicants.Remove(context.Applicants.Find(selected.Id));
                await context.SaveChangesAsync();
                data.Remove(selected);
            }
        }

        private async void editButton_Click(object _, EventArgs __)
        {
            var editForm = new EditForm(selected);
            var result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selected.Name = editForm.Applicant.Name;
                selected.Surname = editForm.Applicant.Surname;
                selected.Patronymic = editForm.Applicant.Patronymic;
                selected.BirthDay = editForm.Applicant.BirthDay;
                selected.FormOfEducation = editForm.Applicant.FormOfEducation;
                selected.Gender = editForm.Applicant.Gender;
                selected.MathScore = editForm.Applicant.MathScore;
                selected.RussianScore = editForm.Applicant.RussianScore;
                selected.ITScore = editForm.Applicant.ITScore;
                bindingSource.ResetBindings(false);
                CalculateScores();
                using var context = new CommitteeContext();
                context.Applicants.AddOrUpdate(editForm.Applicant);
                await context.SaveChangesAsync();
            }
        }


        private async void AddButton_Click(object _, EventArgs __)
        {
            var editForm = new EditForm();
            var result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                data.Insert(0, editForm.Applicant);
                bindingSource.ResetBindings(false);
                using var context = new CommitteeContext();
                context.Applicants.Add(editForm.Applicant);
                await context.SaveChangesAsync();
            }
        }

        private void dataGridView_CellFormatting(object _, DataGridViewCellFormattingEventArgs e)
        {
            var applicant = (Applicant)dataGridView.Rows[e.RowIndex].DataBoundItem;
            var colIndex = e.ColumnIndex;
            var col = dataGridView.Columns[colIndex];
            switch (col.Name)
            {
                case "name":
                    e.Value = $"{applicant.Surname} {applicant.Name} {applicant.Patronymic}".TrimEnd();
                    break;
                case "birthDate":
                    e.Value = applicant.BirthDay.ToShortDateString();
                    break;
                case "formOfEducation":
                    e.Value = Program.GetMemberDisplayName(typeof(FormOfEducation), applicant.FormOfEducation.ToString());
                    break;
                case "gender":
                    e.Value = Program.GetMemberDisplayName(typeof(Gender), applicant.Gender.ToString());
                    break;
                case "totalScore":
                    if ((int)e.Value! >= ScoreThreshold)
                    {
                        dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    }
                    e.Value = e.Value?.ToString();
                    break;
                default:
                    e.Value = e.Value?.ToString();
                    break;
            }
            e.FormattingApplied = true;
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "birthDate")
            {
                e.PaintBackground(e.CellBounds, true);
                var point = new PointF(e.CellBounds.Left + CalendarMargin, e.CellBounds.Top + e.CellBounds.Height / 2 - calendarImage.Height / 2);
                e.Graphics!.DrawImage(calendarImage, point);
                var offset = calendarImage.Width + CalendarMargin * 2;
                var value = ((DateTime)e.Value!).ToShortDateString();
                var valueSize = e.Graphics.MeasureString(value, dataGridView.Font);
                var brush = (e.State & DataGridViewElementStates.Selected) != DataGridViewElementStates.None ? Brushes.White : Brushes.Black;
                var pos = new PointF(e.CellBounds.X + offset, e.CellBounds.Y + e.CellBounds.Height / 2 - valueSize.Height / 2);
                e.Graphics.DrawString(value, dataGridView.Font, brush, pos);
                e.Handled = true;
            }
        }
    }
}
