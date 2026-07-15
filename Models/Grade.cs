namespace IUIS.Models
{
    public class Grade
    {
        public string GradeId { get; set; }
        public string EnrollmentId { get; set; }
        public decimal Score { get; set; }
        public string Remarks { get; set; } // e.g., Passed, Failed, Incomplete
    }
}