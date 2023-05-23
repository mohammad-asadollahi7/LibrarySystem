using LibrarySystem.Entities;

namespace LibrarySystem.Abstraction
{
    public interface ILibraryRepository
    {
        bool BorrowBook(string username, string bookName);
        bool ReturnBook(string username, string bookName);
        List<Book> GetBooksList();
        List<Book> GetBorrowedBooksList(string username);
    }
}
