using LibrarySystem.Entities;

namespace LibrarySystem.Abstraction
{
    public interface ILibrarianRepository
    {
        string AddBook(Book book);
        bool RemoveBook(string bookName);
        List<Book> GetBooksList();

    }
}
