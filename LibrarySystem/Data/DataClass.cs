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
                Password = "989", Role = "2", PersonalityCode = "454"},

            new Librarian() {Name = "Mohammad", Username = "mohammad.kamani8",
                Password = "846", Role = "2", PersonalityCode = "231"},

            new Librarian() {Name = "Mohammad", Username = "mohammad.z94",
                Password = "274", Role = "2", PersonalityCode = "0986"},

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
                     BookName = "soccer", Author = "Amini",
                     Genre = Genres.Sport,
                     IsBorrowed = true, BorrowerUsername = "mohammad.z94",
                     BorrowDate = Convert.ToDateTime("2022-02-02 00:00:00")},
        };
    }
}
