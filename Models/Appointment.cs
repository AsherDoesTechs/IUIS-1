using System;

namespace IUIS.Models
{
    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string RequesterId { get; set; } // Can be Student or Teacher
        public string Purpose { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Cancelled
    }
}