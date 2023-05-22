using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Abstraction
{
    public interface IStorage
    {
        List<Book> GetAvailableBooks();

        List<T> GetData<T>();

        bool SetData<T>(T item);
        
    }
}
