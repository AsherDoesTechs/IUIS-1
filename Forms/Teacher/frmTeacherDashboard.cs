using System.Linq;
using System.Windows.Forms;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Services;
using IUIS.Utilities;
using StudentModel = IUIS.Models.Student;
using TeacherModel = IUIS.Models.Teacher;

namespace IUIS.Forms.Teacher
{
    public partial class frmTeacherDashboard : Form
    {
        private readonly JsonRepository<Subject> _subjectRepo;
        private readonly JsonRepository<TeacherModel> _teacherRepo;
        private readonly JsonRepository<StudentModel> _studentRepo;

        public frmTeacherDashboard()
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(900, 620));
            ModernUi.StyleGrid(dgvTeacherSubjects);
            ModernUi.StyleGrid(dgvStudents);

            _subjectRepo = new JsonRepository<Subject>("Data/subjects.json");
            _teacherRepo = new JsonRepository<TeacherModel>("Data/teachers.json");
            _studentRepo = new JsonRepository<StudentModel>("Data/students.json");
            RepositoryEvents.Changed += RepositoryEvents_Changed;
            FormClosed += (_, _) => RepositoryEvents.Changed -= RepositoryEvents_Changed;
            LoadTeacherSubjects();
        }

        private void LoadTeacherSubjects()
        {
            if (SessionManager.CurrentUser == null)
            {
                dgvTeacherSubjects.DataSource = null;
                dgvStudents.DataSource = null;
                return;
            }

            var teacher = ResolveTeacher();
            var subjects = _subjectRepo.GetAll().ToList();

            if (teacher != null && teacher.AssignedSubjects.Any())
            {
                subjects = subjects.Where(s => teacher.AssignedSubjects.Contains(s.SubjectCode)).ToList();
            }

            var subjectCodes = subjects.Select(s => s.SubjectCode).ToHashSet();
            var roster = _studentRepo.GetAll()
                .Where(s => s.EnrolledCourses.Any(subjectCodes.Contains))
                .Select(s => new
                {
                    s.StudentNumber,
                    Name = s.FullName,
                    s.Program,
                    s.YearLevel,
                    Subjects = string.Join(", ", s.EnrolledCourses.Where(subjectCodes.Contains))
                })
                .OrderBy(s => s.Name)
                .ToList();

            dgvTeacherSubjects.DataSource = subjects
                .Select(s => new
                {
                    Code = s.SubjectCode,
                    s.Title,
                    s.Units,
                    Students = roster.Count(r => r.Subjects.Split(", ").Contains(s.SubjectCode))
                })
                .ToList();
            dgvStudents.DataSource = roster;

            lblTeacherName.Text = teacher != null ? $"{teacher.FirstName} {teacher.LastName}" : SessionManager.CurrentUser.Username;
            lblDepartment.Text = teacher?.Department ?? "Unassigned department";
            lblAssigned.Text = teacher?.AssignedSubjects.Any() == true ? string.Join(", ", teacher.AssignedSubjects) : "No subjects assigned";
            lblSubjectCount.Text = subjects.Count.ToString();
            lblStudentCount.Text = roster.Count.ToString();
            lblRank.Text = teacher?.AcademicRank ?? "Teacher";
        }

        private TeacherModel? ResolveTeacher()
        {
            var userName = SessionManager.CurrentUser?.Username?.Trim();
            if (string.IsNullOrWhiteSpace(userName))
            {
                return null;
            }

            string normalizedUser = userName.ToLowerInvariant();
            var teachers = _teacherRepo.GetAll().ToList();

            return teachers.FirstOrDefault(t =>
                    string.Equals(t.Email, $"{normalizedUser}@iuis.edu", System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(t.Email?.Split('@').FirstOrDefault(), normalizedUser, System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(t.EmployeeNumber, userName, System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(t.FirstName, userName, System.StringComparison.OrdinalIgnoreCase) ||
                    string.Equals($"{t.FirstName}.{t.LastName}".Replace(" ", ""), normalizedUser, System.StringComparison.OrdinalIgnoreCase))
                ?? teachers.FirstOrDefault();
        }

        private void RepositoryEvents_Changed(object? sender, RepositoryChangedEventArgs e)
        {
            if (!IsDisposed)
            {
                BeginInvoke(new Action(LoadTeacherSubjects));
            }
        }
    }
}
