using IUIS.Models.Base;
using System;
using System.Collections.Generic;

namespace IUIS.Models
{
    public class Teacher : Employee
    {
        public string Specialization { get; set; }
        public List<string> AssignedSubjects { get; set; }
        public string AcademicRank { get; set; } // e.g., Instructor, Assistant Professor

        public Teacher() : base()
        {
            AssignedSubjects = new List<string>();
        }
    }
}