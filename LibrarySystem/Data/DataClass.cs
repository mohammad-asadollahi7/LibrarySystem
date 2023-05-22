using LibrarySystem.Abstraction;
using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data
{
    public static class DataClass
    {
        public static List<Person> Persons = new List<Person>()
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
                Password = "900", Role = "2", PersonalityCode = Guid.NewGuid()},

            new Librarian() {Name = "Mohammad", Username = "mohammad.kamani8",
                Password = "901", Role = "2", PersonalityCode = Guid.NewGuid()},

            new Librarian() {Name = "Mohammad", Username = "mohammad.z94",
                Password = "902", Role = "2", PersonalityCode = Guid.NewGuid()},

        };


        public static List<Book> Books = new List<Book>()
        {
                 new Book() {ID = Guid.NewGuid(),
                     BookName = "Math", Author = "Ebrahimi",
                     Genre = Genres.Artistic,
                     IsBorrowed = false, BorrowerUsername = null,
                     BorrowDate = null},

                 new Book() {ID = Guid.NewGuid(),
                     BookName = "1984", Author = "George Orwell",
                     Genre = Genres.Novel,
                     IsBorrowed = false, BorrowerUsername = null,
                     BorrowDate = null},

                 new Book() {ID = Guid.NewGuid(),
                     BookName = "Lord of the Rings", Author = "Tolkien",
                     Genre = Genres.Artistic,
                     IsBorrowed = false, BorrowerUsername = null,
                     BorrowDate = null},

                 new Book() {ID = Guid.NewGuid(),
                     BookName = "Kill a Mockingbird", Author = "Harper Lee",
                     Genre = Genres.Novel,
                     IsBorrowed = true, BorrowerUsername = "mohammad.kamani8",
                     BorrowDate = Convert.ToDateTime("2023-02-02 00:00:00")},

                 new Book() {ID = Guid.NewGuid(),
                     BookName = "Soccer", Author = "Amini",
                     Genre = Genres.Sport,
                     IsBorrowed = true, BorrowerUsername = "mohammad.z94",
                     BorrowDate = Convert.ToDateTime("2022-02-02 00:00:00")},
        };
    }
}
