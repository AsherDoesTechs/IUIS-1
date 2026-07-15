using System.Linq;
using IUIS.Models;

namespace IUIS.Repositories
{
    public class UserRepository : JsonRepository<User>
    {
        public UserRepository() : base("Data/Users.json")
        {
        }

        public User? GetByUsername(string username)
        {
            return GetAll().FirstOrDefault(u => u.Username == username);
        }
    }
}