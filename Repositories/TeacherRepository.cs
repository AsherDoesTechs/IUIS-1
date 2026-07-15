using IUIS.Models;

namespace IUIS.Repositories
{
    public class TeacherRepository : JsonRepository<Teacher>
    {
        public TeacherRepository() : base("Data/Teachers.json") { }
    }
}