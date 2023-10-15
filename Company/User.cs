using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string surname, string username, string email, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
