using LibrarySystem.Abstraction;
using LibrarySystem.DataAccess;
using LibrarySystem.Entities;
using LibrarySystem.Services;
using LibrarySystem.User_Interface__UI_;

class Program
{
    static void Main()
    {
        MemberMenu memberMenu = new MemberMenu();
        LibrarianMenu librarianMenu = new LibrarianMenu();
        Person person;
        bool continueLoop;
        string menuOption2;
        string name;
        string username;
        string password;
        string role;
        IStorage storage;

        Console.WriteLine("Enter the mode of getting and setting data: ");
        Console.WriteLine("1.Json file\n2.static class");
        string menuOption = Console.ReadLine();
        if (menuOption == "1")
            storage = new JsonFileStorage();
        else
            storage = new DataClassStorage();

        Authentication authentication = new Authentication(storage);
        Console.Clear();

        do
        {
            Console.WriteLine("1.Login\n2.Register");
            menuOption2 = Console.ReadLine();
            Console.Clear();
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
                    if (person.Role == "1")
                           memberMenu.Menu(storage, person);
                    else
                        librarianMenu.Menu(storage);

                    continueLoop = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The username or " +
                                         "password is not correct.");
                    continueLoop = true;
                }
            }

            else if (menuOption2 == "2")
            {
                Console.Clear();
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
                    Console.Clear();
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
                    Console.Clear();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("The input is not valid.");
                    continueLoop = true;
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("The input is not valid.");
                continueLoop = true;
            }

        } while (continueLoop);
    }
}
