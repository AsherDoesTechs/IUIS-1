using System;

namespace IUIS.Models
{
    public class Attendance
    {
        public string AttendanceId { get; set; }
        public string StudentId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}   