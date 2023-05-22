using LibrarySystem.Abstraction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            string jsonFilePath = GetJsonPath<Book>();
            string tempString = File.ReadAllText(jsonFilePath);
            var availableBooks = JsonConvert.DeserializeObject<List<Book>>(tempString);
            return availableBooks.Where(u => u.IsBorrowed == false);
        }

        public List<T> GetData<T>()
        {
            string jsonFilePath = GetJsonPath<T>();
            string tempString = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<T>>(tempString);
        }

        public void SetData<T>(List<T> entities)
        {
            string jsonFilePath = GetJsonPath<T>();
            string tempString = JsonConvert.SerializeObject(entities);
            File.WriteAllText(jsonFilePath, tempString);
        }
    }
}
