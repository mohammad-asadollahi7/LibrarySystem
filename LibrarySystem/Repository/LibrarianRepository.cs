using LibrarySystem.Abstraction;
using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repository
{
    public class LibrarianRepository : ILibrarianRepository
    {
        IStorage _storage;

        public string AddBook(Book book)
        {
            var booksList = _storage.GetData<Book>();
            booksList.Add(book);
            _storage.SetData(booksList);
            return $"The {book.BookName} book has been " +
                   $"successfully added to the repository.";
        }

        public List<Book> GetBooksList()
        {

            throw new NotImplementedException();
        }

        public bool RemoveBook(Book book)
        {

            throw new NotImplementedException();
        }
    }
}
