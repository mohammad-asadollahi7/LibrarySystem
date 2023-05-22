using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Abstraction
{
    public interface ILibraryRepository
    {
        bool BorrowBook(string username, string bookName);
        bool ReturnBook(string username, Book book);
        List<Book> GetBooksList();
        List<Book> GetBorrowedBooksList(string username);
    }
}
