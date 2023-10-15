namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company("MyCompany");

            bool check = true;
            do
            {
                Console.WriteLine("==============Menyu==========");
                Console.WriteLine("1-Register a user ( to company");
                Console.WriteLine("2-Login a user(to company)");
                Console.WriteLine("3-See all users in a company(GetAll)");
                Console.WriteLine("4-Get one user by username(GetByUsername)");
                Console.WriteLine("5-Update user's data(UpdateTo)");
                Console.WriteLine("6-Delete user from company(DeleteByUsername)");
                Console.WriteLine("7-Exit");




                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Entern your name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your surname:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        Console.WriteLine("Password must contain at least 1 upper case letter, 1 lower case letter, 1 number and a minimum of 8 characters.");
                        string password = Console.ReadLine();

                        company.ValidatePassword(password);
                        company.Register(name, surname, password);


                        break;

                    case "2":
                        Console.WriteLine("Enter your username:");
                        Console.WriteLine("for example:name.surname");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        string password2 = Console.ReadLine();
                        company.Login(username, password2);

                        break;

                    case "3":
                        company.GetAll();
                        break;


                    case "4":
                        Console.WriteLine("Enter username check:");
                        string UsernameCheck = Console.ReadLine();

                        company.GetByUsername(UsernameCheck);
                        break;


                    case "5":
                        Console.WriteLine("Enter username check:");
                        string UsernameCheck2 = Console.ReadLine();

                        company.UpdatedByUsername(UsernameCheck2);
                        break;

                    case "6":
                        Console.WriteLine("Enter username check:");
                        string UsernameCheck3 = Console.ReadLine();

                        company.DeleteByUsername(UsernameCheck3);
                        break;

                    case "7":
                        Console.WriteLine("Exit.");
                        return;
                    default:
                        Console.WriteLine("Please make the right choice.");
                        break;
                }


            } while (check);
        }
    }
}