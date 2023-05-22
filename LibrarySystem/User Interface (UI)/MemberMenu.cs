using LibrarySystem.Abstraction;
using LibrarySystem.Repository;
using System;

namespace LibrarySystem.Services
{
    public class MemberMenu
    {
        public void Menu(IStorage storage, string username, string password)
        {
            LibraryRepository lr = new LibraryRepository(storage);
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
                        bool isBorrowed = lr.BorrowBook(username, password);
                        if (isBorrowed)
                            Console.WriteLine("The book was successfully borrowed.");
                        else
                        {
                            Console.WriteLine("The Book was not found.");
                            continueLoop = true;    
                        }
                        break;



                }
            } while (continueLoop);



        }

    }
}
