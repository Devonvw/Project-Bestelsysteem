using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string Password {get; set; }

        public Staff(int id, string firstName, string lastName, DateTime birthDate, Roles role, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Role = role;
            Email = email;
            Password = password;
        }
        public Staff(string firstName, string lastName, DateTime birthDate, Roles role, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Role = role;
            Email = email;
        }

        public Staff()
        {
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
