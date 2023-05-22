using LibrarySystem.Abstraction;
using LibrarySystem.Data;
using LibrarySystem.Entities;
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
                var personsList = DataClass.Persons;
                return (List<T>)Convert.ChangeType(personsList, type);
            }
            else if (type == typeof(Book))
            {
                var booksList = DataClass.Books;
                return (List<T>)Convert.ChangeType(booksList, type);
            }
            return null;
        }

        public void SetData<T>(List<T> entities)
        {
            Type type = typeof(T);
            if (type == typeof(Person))
            {
                DataClass.Persons.Clear();
                DataClass.Persons.Add(entities as Person);
            }
            else if (type == typeof(Book))
            {
                DataClass.Books.Clear();
                DataClass.Books.Add(entities as Book);
            }
        }
    }
}
