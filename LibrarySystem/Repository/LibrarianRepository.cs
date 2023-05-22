using LibrarySystem.Abstraction;
using LibrarySystem.Entities;


namespace LibrarySystem.Repository
{
    public class LibrarianRepository : ILibrarianRepository
    {
        IStorage _storage;

        public LibrarianRepository(IStorage storage)
        {
            _storage = storage;
        }

        public string AddBook(Book book)
        {
            var booksList = _storage.GetData<Book>();
            book.ID = Guid.NewGuid();
            book.IsBorrowed = false;
            booksList.Add(book);
            _storage.SetData(booksList);
            return $"The {book.BookName} book has been " +
                   $"successfully added to the repository.";
        }

        public List<Book> GetBooksList()
        {
            return _storage.GetData<Book>();
        }

        public bool RemoveBook(Book book)
        {
            var targetBook = _storage.GetAvailableBooks()
                                .FirstOrDefault(u => u == book);
            if (targetBook != null)
            {
                var BooksList = _storage.GetData<Book>();
                BooksList.Remove(targetBook);
                _storage.SetData<Book>(BooksList);
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
