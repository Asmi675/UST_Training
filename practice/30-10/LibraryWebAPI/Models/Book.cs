﻿namespace LibraryWebAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public string? Genre { get; set; }
        public bool isAvailable { get; set; }
    }
}
