using System;

namespace IUIS.Models
{
    public class Clearance
    {
        public string ClearanceId { get; set; }
        public string StudentId { get; set; }
        public string Department { get; set; } // e.g., Library, Registrar
        public bool IsCleared { get; set; }
        public string Remarks { get; set; }
    }
}