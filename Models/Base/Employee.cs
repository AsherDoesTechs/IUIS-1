using System;

namespace IUIS.Models.Base
{
    public class Employee : Person
    {
        public string EmployeeNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime DateHired { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }

        public Employee() : base()
        {
            IsActive = true;
        }
    }
}