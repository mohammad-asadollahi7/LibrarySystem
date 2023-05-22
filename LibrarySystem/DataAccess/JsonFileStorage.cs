using LibrarySystem.Abstraction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LibrarySystem.DataAccess
{
    public class JsonFileStorage : IStorage
    {
        public string GetJsonPath<T>()
        {
            Type type = typeof(T);
            string? projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
                            .Parent?.Parent?.Parent?.FullName;
            string? dataFolderPath = Path.Combine(projectPath, "Data");
            string? jsonFilePath = Path.Combine(dataFolderPath, $"{type}.json");
            return jsonFilePath;        
        }
        public List<Book> GetAvailableBooks()
        {

        }

        public List<T> GetData<T>()
        {
            throw new NotImplementedException();
        }

        public bool SetData<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
