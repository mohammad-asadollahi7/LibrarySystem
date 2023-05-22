using LibrarySystem.Abstraction;
using LibrarySystem.Entities;
using LibrarySystem.Repository;
using System;

namespace LibrarySystem.User_Interface__UI_
{
    public class LibrarianMenu
    {
        public void Menu(IStorage storage)
        {
            LibrarianRepository librarianRepository
                            = new LibrarianRepository(storage);
            bool continueLoop = false;
            char backToMenu;
            string menuOption = string.Empty;
            string message = string.Empty;
            string bookName = string.Empty;
            Book book = new Book();
            List<Book> booksList;

            do
            {
                Console.WriteLine("1.Adding book" +
                                  "\n2.Removing Book" +
                                  "\n3.Showing all books list" +
                                  "\n4.Exist");

                menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        Console.Write("Enter the book name: ");
                        book.BookName = Console.ReadLine();
                        Console.WriteLine("Enter the author name: ");
                        book.Author = Console.ReadLine();
                        Console.WriteLine("Enter the number of specific genre:\n" +
                                           "1.Scientific\n2.Artistic\n3.Sport\n4.Novel");
                        book.Genre = (Genres)Enum.Parse(typeof(Genres), Console.ReadLine());

                        message = librarianRepository.AddBook(book);
                        Console.WriteLine(message);

                        Console.Write("Back to librarian menu (y/n): ");
                        backToMenu = Convert.ToChar(Console.ReadLine());
                        if (backToMenu == 'y')
                            continueLoop = true;
                        else
                            continueLoop = false;

                        break;

                    case "2":
                        booksList = librarianRepository.GetBooksList()
                                           .Where(u => u.IsBorrowed == false).ToList();

                        foreach (var b in booksList)
                        {
                            Console.WriteLine(b.BookName);
                        }
                        Console.WriteLine("Book name for removing: ");
                        bookName = Console.ReadLine();

                        bool isValid = librarianRepository.RemoveBook(bookName);
                        if (isValid)
                        {
                            Console.WriteLine($"{bookName} book was successfully" +
                                             "removed from the repository");

                            Console.Write("Back to librarian menu (y/n): ");
                            backToMenu = Convert.ToChar(Console.ReadLine());
                            if (backToMenu == 'y')
                                continueLoop = true;
                            else
                                continueLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("The book name was invalid.");
                            continueLoop = true;
                        }
                        break;


                    case "3":
                        booksList = librarianRepository.GetBooksList();

                        foreach (var b in booksList)
                        {
                            Console.WriteLine("Book name: " + b.BookName + 
                                        "   is it Borrowed?: " + b.IsBorrowed);
                        }

                        Console.Write("\nBack to librarian menu (y/n): ");
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
