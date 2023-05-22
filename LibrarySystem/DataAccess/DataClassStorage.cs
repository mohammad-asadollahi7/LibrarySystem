using LibrarySystem.Abstraction;
using LibrarySystem.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DataAccess
{
    public class DataClassStorage : IStorage
    {
        public List<Book> GetAvailableBooks()
        {
            return DataClass.Books.Where
                       (u => u.IsBorrowed == false).ToList();
        }

        public List<T> GetData<T>()
        {
            Type type = typeof(T);
            if (type == typeof(Person))
            {
                var personsList = DataClass.Persons.Select(u => u).ToList();
                return (List<T>)Convert.ChangeType(personsList, type);
            }
            else if (type == typeof(Book))
            {
                var booksList = DataClass.Persons.Select(u => u).ToList();
                return (List<T>)Convert.ChangeType(booksList, type);
            }
        }

        public void SetData<T>(List<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
