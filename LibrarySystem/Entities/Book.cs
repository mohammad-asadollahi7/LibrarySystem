﻿
namespace LibrarySystem.Entities
{
    public class Book
    {
        public Guid ID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public Genres Genre { get; set; }
        public bool IsBorrowed { get; set; }
        public string? BorrowerUsername {get ; set; }
        public DateTime? BorrowDate { get; set; }
    }
}
