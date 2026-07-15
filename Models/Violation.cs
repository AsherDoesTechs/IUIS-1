using System;

namespace IUIS.Models
{
    public class Violation
    {
        public string ViolationId { get; set; }
        public string StudentId { get; set; }
        public string OffenseType { get; set; }
        public DateTime DateCommitted { get; set; }
        public string DisciplinaryAction { get; set; }
    }
}