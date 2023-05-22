using LibrarySystem.Abstraction;
using LibrarySystem.Entities;
using LibrarySystem.Repository;
using System;

namespace LibrarySystem.Services
{
    public class MemberMenu
    {
        public void Menu(IStorage storage, string username, string password)
        {
            LibraryRepository libraryRepository = new LibraryRepository(storage);
            bool continueLoop = false;
            do
            {
                Console.WriteLine("1.Borrowing book" +
                                  "\n2.Returning Book" +
                                  "\n3.Showing Borrow books list");
                var menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        bool isBorrowed = libraryRepository.BorrowBook(username, password);
                        if (isBorrowed)
                            Console.WriteLine("The book was successfully borrowed.");
                        else
                        {
                            Console.WriteLine("The Book was not found.");
                            continueLoop = true;    
                        }
                        break;

                    case "2":

                        var borrowedBooksList = libraryRepository.GetBorrowedBooksList(username);
                        Console.WriteLine("Books borrowed by you: ");
                        foreach (var book in borrowedBooksList)
                        {
                            Console.WriteLine(book.BookName);
                        }

                        Console.WriteLine("Book name to return: ");
                        var bookName = Console.ReadLine();
                        bool isReturned = libraryRepository.ReturnBook(username, bookName);

                        if (isReturned)
                            Console.WriteLine($"{bookName} book was successfully returned.");
                        else
                        {
                            Console.WriteLine($"This member has not borrowed" +
                                                 $" {bookName} book before.");
                            continueLoop = true;
                        }
                        break;

                     



                }
            } while (continueLoop);



        }

    }
}
