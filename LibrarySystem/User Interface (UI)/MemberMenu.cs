using LibrarySystem.Abstraction;
using LibrarySystem.Entities;
using LibrarySystem.Repository;


namespace LibrarySystem.Services
{
    public class MemberMenu
    {
        public void Menu(IStorage storage, Person person)
        {
            LibraryRepository libraryRepository
                        = new LibraryRepository(storage);
            bool continueLoop = false;
            char backToMenu;
            List<Book> borrowedBooksList;
            string bookName = string.Empty;
            string menuOption = string.Empty;

            do
            {
                Console.WriteLine("1.Borrowing book" +
                                  "\n2.Returning Book" +
                                  "\n3.Showing Borrow books list" +
                                  "\n4.Exist");
                menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        bool isBorrowed = libraryRepository.BorrowBook
                                                (person.Username, person.Password);
                        if (isBorrowed)
                        {
                            Console.WriteLine("The book was successfully borrowed.");
                            Console.Write("Back to member menu (y/n): ");
                            backToMenu = Convert.ToChar(Console.ReadLine());
                            if (backToMenu == 'y')
                                continueLoop = true;
                            else
                                continueLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("The Book was not found.");
                            continueLoop = true;    
                        }
                        break;

                    case "2":

                         borrowedBooksList = libraryRepository.GetBorrowedBooksList
                                                                    (person.Username);
                        Console.WriteLine($"Books borrowed by {person.Name}: ");
                        foreach (var book in borrowedBooksList)
                        {
                            Console.WriteLine(book.BookName);
                        }

                        Console.WriteLine("\nBook name to return: ");
                        bookName = Console.ReadLine();
                        bool isReturned = libraryRepository.ReturnBook
                                                          (person.Username, bookName);

                        if (isReturned)
                        {
                            Console.WriteLine($"{bookName} book was successfully returned.");
                            Console.Write("Back to member menu (y/n): ");
                             backToMenu = Convert.ToChar(Console.ReadLine());
                            if (backToMenu == 'y')
                                continueLoop = true;
                            else
                                continueLoop = false;
                        }
                        else
                        {
                            Console.WriteLine($"{person.Name} has not borrowed" +
                                                 $" {bookName} book before.");
                            continueLoop = true;
                        }
                        break;

                    case "3":
                        borrowedBooksList = libraryRepository.GetBorrowedBooksList
                                                                   (person.Username);
                        Console.WriteLine($"Books borrowed by {person.Name}:\n");
                        foreach (var book in borrowedBooksList)
                        {
                            Console.WriteLine(book.BookName);
                        }

                        Console.Write("Back to member menu (y/n): ");
                        backToMenu = Convert.ToChar(Console.ReadLine());
                        if (backToMenu == 'y')
                            continueLoop = true;
                        else
                            continueLoop = false;

                        break;

                    case "4":
                        Console.WriteLine("Good bye.");
                        break;

                    default:
                        Console.WriteLine("The input is not valid.");
                        continueLoop = true;
                        break;
                }
            } while (continueLoop);



        }

    }
}
