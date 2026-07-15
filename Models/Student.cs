using IUIS.Models.Base;
using System;
using System.Collections.Generic;

namespace IUIS.Models
{
    public class Student : Person
    {
        public string StudentNumber { get; set; }
        public string YearLevel { get; set; }
        public string Program { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; } // e.g., Regular, Irregular, Graduated
        public List<string> EnrolledCourses { get; set; }

        public Student() : base()
        {
            EnrolledCourses = new List<string>();
            Status = "Active";
        }
    }
}