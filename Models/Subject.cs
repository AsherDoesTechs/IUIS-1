namespace IUIS.Models
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string SubjectCode { get; set; }
        public string Title { get; set; }
        public int Units { get; set; }
        public string CourseId { get; set; }

        public Subject() { }
    }
}