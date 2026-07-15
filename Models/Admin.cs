using IUIS.Models.Base;
using System;

namespace IUIS.Models
{
    public class Admin : Employee
    {
        public string AdminLevel { get; set; } // e.g., SuperAdmin, RegularAdmin
        public string Permissions { get; set; } // Could be serialized JSON or flag-based

        public Admin() : base()
        {
        }
    }
}