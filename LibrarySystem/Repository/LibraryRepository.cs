using LibrarySystem.Abstraction;
using LibrarySystem.Entities;
using System.Globalization;

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
            var requestedBook = _storage.GetAvailableBooks().
                                    FirstOrDefault(u => u.bookName == bookName);

            if (requestedBook != null)
            {
                requestedBook.IsBorrowed = true;
                requestedBook.BorrowerUsername = username;
                requestedBook.BorrowDate = DateTime.Today;
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

        public List<Book> GetBorrowedBooksList(string username)
        {
            return _storage.GetData<Book>().Where
                       (u => u.BorrowerUsername == username).ToList();
        }

        public bool ReturnBook(string username, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
