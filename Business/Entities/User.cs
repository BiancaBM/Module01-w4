using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }

        public User()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
        }

        public User(string email, string firstName, string lastName,  DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
            this.Email = email;
        }

    }
}
