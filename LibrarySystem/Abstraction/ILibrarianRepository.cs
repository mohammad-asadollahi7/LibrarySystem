﻿using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Abstraction
{
    public interface ILibrarianRepository
    {
        string AddBook(Book book);
        bool RemoveBook(Book book);
        List<Book> GetBooksList();

    }
}
