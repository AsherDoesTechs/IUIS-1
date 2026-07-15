using System;

namespace IUIS.Models
{
    public class Payment
    {
        public string PaymentId { get; set; }
        public string StudentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; } // e.g., Tuition, Library Fee
    }
}