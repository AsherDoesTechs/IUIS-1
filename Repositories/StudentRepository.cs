using IUIS.Models;

namespace IUIS.Repositories
{
    public class StudentRepository : JsonRepository<Student>
    {
        public StudentRepository() : base("Data/Students.json")
        {
        }

        public Student? GetByStudentNumber(string studentNumber)
        {
            return GetAll().FirstOrDefault(s => s.StudentNumber == studentNumber);
        }
    }
}