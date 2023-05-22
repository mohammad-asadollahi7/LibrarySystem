using LibrarySystem.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data
{
    public static class DataClass
    {
        public static List<Person> persons = new List<Person>()
        {
            new Member() {Name = "Mohammad", Username = "mohammad.a75",
                Password = "123", Role = "1",
                RegisterDate = Convert.ToDateTime("2020-09-05 00:00:00") },

            new Member() {Name = "Ali", Username = "Ali.sh3",
                Password = "321", Role = "1",
                RegisterDate = Convert.ToDateTime("2021-10-05 00:00:00") },

            new Member() {Name = "Ehsan", Username = "Ehsan.g65",
                Password = "456", Role = "1",
                RegisterDate = Convert.ToDateTime("2023-05-11 00:00:00") },

            new Librarian() {Name = "abbas", Username = "abbas.i7",
                Password = "989", Role = "2", PersonalityCode = 587},

            new Librarian() {Name = "Mohammad", Username = "mohammad.kamani8",
                Password = "846", Role = "2", PersonalityCode = 984},

            new Librarian() {Name = "Mohammad", Username = "mohammad.z94",
                Password = "274", Role = "2", PersonalityCode = 236},

        };


        public static List<Book> books = new List<Book>()
        {
                 new Book() {ID = Guid.NewGuid(),
                     NameofBook = "Math", Author = "Ebrahimi",
                     Genre = Genres.artistic,
                     IsBorrowed = false, BorrowerUsername = null,
                     date = null},

                 new Book() {ID = Guid.NewGuid(),
                     NameofBook = "1984", Author = "George Orwell",
                     Genre = Genres.novel,
                     IsBorrowed = false, BorrowerUsername = null,
                     date = null},

                 new Book() {ID = Guid.NewGuid(),
                     NameofBook = "Lord of the Rings", Author = "Tolkien",
                     Genre = Genres.artistic,
                     IsBorrowed = false, BorrowerUsername = null,
                     date = null},

                 new Book() {ID = Guid.NewGuid(),
                     NameofBook = "Kill a Mockingbird", Author = "Harper Lee",
                     Genre = Genres.novel,
                     IsBorrowed = true, BorrowerUsername = "mohammad.kamani8",
                     date = Convert.ToDateTime("2023-02-02 00:00:00")},

                 new Book() {ID = Guid.NewGuid(),
                     NameofBook = "soccer", Author = "Amini",
                     Genre = Genres.sport,
                     IsBorrowed = true, BorrowerUsername = "mohammad.z94",
                     date = Convert.ToDateTime("2022-02-02 00:00:00")},
        };
    }
}
