using System;

namespace IUIS.Models
{
    public class Counseling
    {
        public string CounselingId { get; set; }
        public string StudentId { get; set; }
        public string CounselorId { get; set; }
        public DateTime SessionDate { get; set; }
        public string Notes { get; set; }
        public string Recommendation { get; set; }
    }
}