using System;
using System.Linq;
using System.Windows.Forms;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Utilities;
using TeacherModel = IUIS.Models.Teacher;

namespace IUIS.Forms.Admin
{
    public partial class frmManageTeachers : Form
    {
        private readonly JsonRepository<TeacherModel> _teacherRepo;
        private readonly JsonRepository<Subject> _subjectRepo;

        public frmManageTeachers()
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(360, 320));
            ModernUi.StyleGrid(dgvTeachers);
            ModernUi.StylePrimaryButton(btnSave);
            ModernUi.StyleSecondaryButton(btnDelete);
            ModernUi.StyleTextBox(txtFirstName);
            ModernUi.StyleTextBox(txtLastName);
            ModernUi.StyleTextBox(txtEmail);
            ModernUi.StyleTextBox(txtDepartment);
            ModernUi.StyleTextBox(txtSpecialization);

            _teacherRepo = new JsonRepository<TeacherModel>("Data/teachers.json");
            _subjectRepo = new JsonRepository<Subject>("Data/subjects.json");
            LoadSubjects();
            LoadData();
        }

        private void LoadSubjects()
        {
            checkedSubjects.Items.Clear();

            foreach (var subject in _subjectRepo.GetAll().OrderBy(s => s.SubjectCode))
            {
                checkedSubjects.Items.Add(subject.SubjectCode);
            }
        }

        private void LoadData()
        {
            dgvTeachers.DataSource = null;
            dgvTeachers.DataSource = _teacherRepo.GetAll()
                .OrderBy(t => t.LastName)
                .Select(t => new
                {
                    t.Id,
                    Name = t.FullName,
                    t.Email,
                    t.Department,
                    t.Specialization,
                    Subjects = string.Join(", ", t.AssignedSubjects)
                })
                .ToList();

            var idColumn = dgvTeachers.Columns["Id"];
            if (idColumn != null)
            {
                idColumn.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter both first and last name.", "Teacher Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedSubjects = checkedSubjects.CheckedItems.Cast<string>().ToList();
            var firstName = txtFirstName.Text.Trim();
            var lastName = txtLastName.Text.Trim();

            var teacher = new TeacherModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = string.IsNullOrWhiteSpace(txtEmail.Text)
                    ? $"{firstName}.{lastName}".Replace(" ", "").ToLowerInvariant() + "@iuis.edu"
                    : txtEmail.Text.Trim(),
                Department = string.IsNullOrWhiteSpace(txtDepartment.Text) ? "General Education" : txtDepartment.Text.Trim(),
                Specialization = string.IsNullOrWhiteSpace(txtSpecialization.Text) ? "General Studies" : txtSpecialization.Text.Trim(),
                Position = "Teacher",
                AcademicRank = "Instructor",
                EmployeeNumber = IDGenerator.GenerateSequential("TCH", _teacherRepo.GetAll().Select(t => t.EmployeeNumber)),
                DateHired = DateTime.Today,
                AssignedSubjects = selectedSubjects
            };

            _teacherRepo.Add(teacher);
            ClearEntry();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a teacher row before deleting.", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedId = dgvTeachers.SelectedRows[0].Cells["Id"].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedId))
            {
                _teacherRepo.Delete(selectedId);
                LoadData();
            }
        }

        private void ClearEntry()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();

            for (int i = 0; i < checkedSubjects.Items.Count; i++)
            {
                checkedSubjects.SetItemChecked(i, false);
            }
        }
    }
}
