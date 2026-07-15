using System;

namespace IUIS.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Student, Teacher, Admin
        public bool IsEnabled { get; set; }
        public DateTime? LastLogin { get; set; }

        public User()
        {
            UserId = Guid.NewGuid().ToString();
            IsEnabled = true;
        }
    }
}