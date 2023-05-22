using LibrarySystem.Abstraction;
using LibrarySystem.DataAccess;
using LibrarySystem.Entities;
using LibrarySystem.Services;

class Program
{
    static void Main()
    {
        MemberMenu memberMenu = new MemberMenu();
        Person person;
        bool continueLoop = false;
        string menuOption2 = string.Empty;
        string name = string.Empty;
        string username = string.Empty;
        string password = string.Empty;
        string role = string.Empty;
        IStorage storage;

        Console.WriteLine("Enter the mode of getting and setting data: ");
        Console.WriteLine("1.Json file\n2.static class\n");
        string menuOption = Console.ReadLine();
        if (menuOption == "1")
            storage = new JsonFileStorage();
        else
            storage = new DataClassStorage();

        Authentication authentication = new Authentication(storage);
        


        do
        {
            Console.WriteLine("1.Login\n2.Register\n");
            menuOption2 = Console.ReadLine();

            if (menuOption2 == "1")
            {
                Console.WriteLine("Login section:");

                Console.Write("Enter username: ");
                username = Console.ReadLine();

                Console.Write("Enter password: ");
                password = Console.ReadLine();

                person = authentication.Login(username, password);

                if (person != null)
                {
                    Console.WriteLine("Welcome to the member menu\n");
                    memberMenu.Menu(storage, person);
                    continueLoop = false;
                }
                else
                {
                    Console.WriteLine("The username or " +
                                         "password is not correct.");
                    continueLoop = true;
                }
            }

            else if (menuOption2 == "2")
            {
                Console.WriteLine("Register section: ");
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.Write("Enter username: ");
                username = Console.ReadLine();

                Console.Write("Enter password: ");
                password = Console.ReadLine();

                Console.WriteLine("Your role:\n1.Member" +
                                  "\n2.Librarian");
                role = Console.ReadLine();

                if (role == "1")
                {
                    authentication.Register(new Member()
                    {
                        Name = name,
                        Username = username,
                        Password = password,
                        Role = role
                    });
                    continueLoop = true;

                }

                else if (role == "2")
                {
                    authentication.Register(new Librarian()
                    {
                        Name = name,
                        Username = username,
                        Password = password,
                        Role = role
                    });
                    continueLoop = true;
                }

                else
                {
                    Console.WriteLine("The input is not valid.");
                    continueLoop = true;
                }
            }

            else
            {
                Console.WriteLine("The input is not valid.");
                continueLoop = true;
            }

        } while (continueLoop);
    }
}
