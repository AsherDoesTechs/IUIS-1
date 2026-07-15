using System.Linq;
using System.Windows.Forms;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Services;
using IUIS.Utilities;
using StudentModel = IUIS.Models.Student;

namespace IUIS.Forms.Student
{
    public partial class frmStudentDashboard : Form
    {
        private readonly JsonRepository<StudentModel> _studentRepo;
        private readonly JsonRepository<Subject> _subjectRepo;

        public frmStudentDashboard()
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(860, 560));
            ModernUi.StyleGrid(dgvSubjects);

            _studentRepo = new JsonRepository<StudentModel>("Data/students.json");
            _subjectRepo = new JsonRepository<Subject>("Data/subjects.json");
            RepositoryEvents.Changed += RepositoryEvents_Changed;
            FormClosed += (_, _) => RepositoryEvents.Changed -= RepositoryEvents_Changed;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            var student = ResolveStudent();
            if (student == null)
            {
                lblStudentName.Text = SessionManager.CurrentUser?.Username ?? "Student";
                lblProgram.Text = "No student record found";
                lblStudentNumber.Text = "Student No: Not linked";
                lblStatus.Text = "Status: Unknown";
                lblYearLevel.Text = "Year Level: Unknown";
                lblCourseCount.Text = "0";
                dgvSubjects.DataSource = null;
                return;
            }

            var courseCodes = student.EnrolledCourses.ToHashSet();
            var subjects = _subjectRepo.GetAll()
                .Where(s => courseCodes.Contains(s.SubjectCode))
                .Select(s => new
                {
                    Code = s.SubjectCode,
                    s.Title,
                    s.Units
                })
                .OrderBy(s => s.Code)
                .ToList();

            lblStudentName.Text = student.FullName;
            lblProgram.Text = student.Program;
            lblStudentNumber.Text = $"Student No: {student.StudentNumber}";
            lblStatus.Text = $"Status: {student.Status}";
            lblYearLevel.Text = $"Year Level: {student.YearLevel}";
            lblCourseCount.Text = subjects.Count.ToString();
            lblCourseCaption.Text = $"Enrolled subjects • GPA {new GpaService().Calculate(student.Id):0.00}";
            lblSubjectsTitle.Text = "My Enrollment & Academic Records";
            dgvSubjects.DataSource = subjects;
        }

        private StudentModel? ResolveStudent()
        {
            var userName = SessionManager.CurrentUser?.Username?.Trim();
            if (string.IsNullOrWhiteSpace(userName))
            {
                return null;
            }

            string normalizedUser = userName.ToLowerInvariant();
            var students = _studentRepo.GetAll().ToList();

            return students.FirstOrDefault(s =>
                    string.Equals(s.Email, $"{normalizedUser}@iuis.edu", System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(s.Email?.Split('@').FirstOrDefault(), normalizedUser, System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(s.StudentNumber, userName, System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(s.FirstName, userName, System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals($"{s.FirstName}.{s.LastName}".Replace(" ", ""), normalizedUser, System.StringComparison.OrdinalIgnoreCase))
                ?? students.FirstOrDefault();
        }

        private void RepositoryEvents_Changed(object? sender, RepositoryChangedEventArgs e)
        {
            if (!IsDisposed)
            {
                BeginInvoke(new Action(LoadStudentData));
            }
        }
    }
}
