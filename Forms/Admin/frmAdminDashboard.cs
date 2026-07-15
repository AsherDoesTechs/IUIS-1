using System;
using System.Windows.Forms;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Services;
using IUIS.Utilities;
using StudentModel = IUIS.Models.Student;
using TeacherModel = IUIS.Models.Teacher;

namespace IUIS.Forms.Admin
{
    public partial class frmAdminDashboard : Form
    {
        private readonly JsonRepository<StudentModel> _studentRepo;
        private readonly JsonRepository<TeacherModel> _teacherRepo;
        private readonly JsonRepository<Subject> _subjectRepo;

        public frmAdminDashboard()
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(1000, 760));
            ModernUi.StylePrimaryButton(btnManageStudents);
            ModernUi.StyleSecondaryButton(btnManageTeachers);

            _studentRepo = new JsonRepository<StudentModel>("Data/students.json");
            _teacherRepo = new JsonRepository<TeacherModel>("Data/teachers.json");
            _subjectRepo = new JsonRepository<Subject>("Data/subjects.json");
            RepositoryEvents.Changed += RepositoryEvents_Changed;
            FormClosed += (_, _) => RepositoryEvents.Changed -= RepositoryEvents_Changed;
            LoadSummary();
            OpenChildForm(new frmManageStudents());
        }

        private void LoadSummary()
        {
            lblStudentCount.Text = $"{_studentRepo.GetAll().Count()}\nStudents";
            lblTeacherCount.Text = $"{_teacherRepo.GetAll().Count()}\nTeachers";
            lblSubjectCount.Text = $"{_subjectRepo.GetAll().Count()}\nSubjects";
        }

        private void OpenChildForm(Form childForm)
        {
            panelContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnManageStudents, btnManageTeachers);
            OpenChildForm(new frmManageStudents());
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnManageTeachers, btnManageStudents);
            OpenChildForm(new frmManageTeachers());
        }

        private void SetActiveButton(Button active, Button inactive)
        {
            ModernUi.StylePrimaryButton(active);
            ModernUi.StyleSecondaryButton(inactive);
        }

        private void RepositoryEvents_Changed(object? sender, RepositoryChangedEventArgs e)
        {
            if (!IsDisposed)
            {
                BeginInvoke(new Action(LoadSummary));
            }
        }
    }
}
