using LibrarySystem.Abstraction;
using LibrarySystem.Entities;

namespace LibrarySystem.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private IStorage _storage;

        public LibraryRepository(IStorage storage)
        {
            _storage = storage;
        }

        public bool BorrowBook(string username, string bookName)
        {
            var booksList = _storage.GetData<Book>();
            var requestedBook = booksList.FirstOrDefault
                                (u => u.BookName == bookName
                                  && u.IsBorrowed == false);

            if (requestedBook != null)
            {
                requestedBook.IsBorrowed = true;
                requestedBook.BorrowerUsername = username;
                requestedBook.BorrowDate = DateTime.Today;
                _storage.SetData<Book>(booksList);
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Book> GetBooksList()
        {
            return _storage.GetData<Book>();
        }

        public List<Book> GetBorrowedBooksList(string? username)
        {
            return _storage.GetData<Book>().Where
                       (u => u.BorrowerUsername == username).ToList();
        }

        public bool ReturnBook(string username, string bookName)
        {
            var booksList = _storage.GetData<Book>();
            var targetBook = booksList?.FirstOrDefault
                                (u => u.BorrowerUsername == username
                                 && u.BookName == bookName);

            if (targetBook != null)
            {
                targetBook.IsBorrowed = false;
                targetBook.BorrowerUsername = null;
                targetBook.BorrowDate = null;
                _storage.SetData<Book>(booksList);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
