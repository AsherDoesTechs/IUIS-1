using System;

namespace IUIS.Models
{
    public class Consultation
    {
        public string ConsultationId { get; set; }
        public string StudentId { get; set; }
        public string TeacherId { get; set; }
        public DateTime Schedule { get; set; }
        public string Topic { get; set; }
        public string Status { get; set; } // e.g., Pending, Completed
    }
}