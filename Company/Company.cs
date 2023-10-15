using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Company
{
    internal class Company
    {
        public string Name { get; set; }
        public User[] users;
        public Company(string name)
        {
            Name = name;
            users = new User[0];

        }
        public void Register(string name, string surname, string password)
        {
            string username = name.ToLower() + "." + surname.ToLower();
            string email = $"{name.ToLower()}.{surname.ToLower()}@gmail.com";
            if (password.Length > 5)
            {
                User user = new User(name, surname, username, email, password);
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = user;





            }
            else
            {
                Console.WriteLine("Passwor is not correctly.");
            }
        }
        public void Login(string username, string password)
        {
            bool checkLogin = false;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    checkLogin = true;
                    break;
                }
            }
            if (checkLogin)
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("Username or password is incorrect.");
            }
        }

        public void GetAll()
        {
            if (users.Length > 0)
            {
                foreach (User user in users)
                {
                    Console.WriteLine($"Name:{user.Name}, Surname:{user.Surname}, Username:{user.Username}");
                }
            }
            else
            {
                Console.WriteLine("There is no such user in company.");
            }
        }


        public void GetByUsername(string UsernameCheck)
        {
            if (users.Length > 0)
            {
                foreach (User user in users)
                {
                    if (UsernameCheck == user.Username)
                    {
                        Console.WriteLine($"User name:{user.Name}, surname:{user.Surname}, email:{user.Email}  ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("There is no such user in company.");
                    }
                }
            }

        }
        public void UpdatedByUsername(string UsernameCheck2)
        {
            Console.WriteLine("a.Update name");
            Console.WriteLine("b.Update surname");
            Console.WriteLine("c.Update username");
            Console.WriteLine("d.Update email");
            Console.WriteLine("Enter ");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "a":
                    Console.WriteLine("Enter your new name: ");
                    string NewName = Console.ReadLine();
                    foreach (User user in users)
                    {
                        if (UsernameCheck2 == user.Username)
                        {
                            user.Name = NewName;
                            break;
                        }
                    }
                    break;

                case "b":
                    Console.WriteLine("Enter your new surname: ");
                    string NewSurname = Console.ReadLine();
                    foreach (User user in users)
                    {
                        if (UsernameCheck2 == user.Username)
                        {
                            user.Surname = NewSurname;
                            break;
                        }
                    }
                    break;


                case "c":
                    Console.WriteLine("Enter your new username: ");
                    string NewUsername = Console.ReadLine();
                    foreach (User user in users)
                    {
                        if (UsernameCheck2 == user.Username)
                        {
                            user.Username = NewUsername;
                            break;
                        }
                    }
                    break;

                case "d":
                    Console.WriteLine("Enter your new email: ");
                    string NewEmail = Console.ReadLine();
                    foreach (User user in users)
                    {
                        if (UsernameCheck2 == user.Username)
                        {
                            user.Email = NewEmail;
                            break;
                        }
                    }

                    break;

            }

        }

        public void DeleteByUsername(string UsernameCheck3)
        {
            User[] UsersOfCompany = new User[users.Length - 1];
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username == UsernameCheck3)
                {
                    continue;
                }
                UsersOfCompany[i] = users[i];
            }
            users = UsersOfCompany;
        }

        public bool ValidatePassword(string password)
        {
            var input = password;


            var hasLowerChar = new Regex(@"[a-z]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasNumber = new Regex(@"[0-9]+");
            var hasMinChars = new Regex(@".{8,}");




            if (!hasLowerChar.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one lower case letter.");
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one upper case letter.");
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one numeric value.");
                return false;
            }
            else if (!hasMinChars.IsMatch(input))
            {
                Console.WriteLine("Password should not be lesser than 8  characters.");
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
