using System;

namespace IUIS.Models.Base
{
    /// <summary>
    /// Base class representing a person in the system.
    /// </summary>
    public abstract class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        protected Person()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}