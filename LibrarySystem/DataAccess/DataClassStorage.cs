using LibrarySystem.Abstraction;
using LibrarySystem.Data;
using LibrarySystem.Entities;
using System.Collections;


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
            List<T> data = new List<T>();
            Type type = typeof(T);
            if (type == typeof(Person))
            {
                var personsList = DataClass.Persons;
                data = ((IEnumerable)personsList).Cast<T>().ToList();
            }
            else if (type == typeof(Book))
            {
                var booksList = DataClass.Books;
                data = ((IEnumerable)booksList).Cast<T>().ToList();
            }
            return data;
        }

        public void SetData<T>(List<T> entities)
        {
            Type type = typeof(T);
            if (type == typeof(Person))
            {
                DataClass.Persons.Clear();
                for (int i = 0; i < entities.Count(); i++)
                    DataClass.Persons.Add(entities[i] as Person);
                
            }
            else if (type == typeof(Book))
            {
                DataClass.Books.Clear();
                for (int i =0; i < entities.Count(); i++)
                    DataClass.Books.Add(entities[i] as Book);
            }
        }
    }
}
