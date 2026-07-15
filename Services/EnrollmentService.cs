using System;
using System.Linq;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Utilities;

namespace IUIS.Services
{
    public class EnrollmentService
    {
        private const int MaximumUnits = 27;
        private readonly JsonRepository<Enrollment> _enrollments = new("JSON/enrollments.json");
        private readonly JsonRepository<Subject> _subjects = new("Data/subjects.json");

        public (bool IsValid, string Message) Enroll(string studentId, string subjectId, string semester, string schoolYear)
        {
            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(subjectId))
                return (false, "Student and subject are required.");
            if (_enrollments.GetAll().Any(e => e.StudentId == studentId && e.SubjectId == subjectId && e.Semester == semester && e.SchoolYear == schoolYear))
                return (false, "The subject is already in this student's enrollment.");

            var subject = _subjects.GetAll().FirstOrDefault(s => s.SubjectId == subjectId);
            if (subject == null) return (false, "The selected subject was not found.");
            int units = _enrollments.GetAll().Where(e => e.StudentId == studentId && e.Semester == semester && e.SchoolYear == schoolYear)
                .Join(_subjects.GetAll(), e => e.SubjectId, s => s.SubjectId, (_, s) => s.Units).Sum();
            if (units + subject.Units > MaximumUnits)
                return (false, $"Enrollment would exceed the {MaximumUnits}-unit limit.");

            _enrollments.Add(new Enrollment { EnrollmentId = IDGenerator.Generate("ENR"), StudentId = studentId, SubjectId = subjectId, Semester = semester, SchoolYear = schoolYear, EnrollmentDate = DateTime.Today });
            return (true, "Enrollment request saved.");
        }
    }
}
