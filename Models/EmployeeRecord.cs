using System;

namespace IUIS.Models
{
    public class EmployeeRecord
    {
        public string RecordId { get; set; }
        public string EmployeeId { get; set; }
        public string PerformanceRating { get; set; }
        public string Remarks { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}