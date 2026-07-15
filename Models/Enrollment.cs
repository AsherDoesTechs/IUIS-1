using System;

namespace IUIS.Models
{
    public class Enrollment
    {
        public string EnrollmentId { get; set; }
        public string StudentId { get; set; }
        public string SubjectId { get; set; }
        public string Semester { get; set; }
        public string SchoolYear { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}