using System;

namespace IUIS.Models
{
    public class Borrowing
    {
        public string BorrowingId { get; set; }
        public string BookId { get; set; }
        public string StudentId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}