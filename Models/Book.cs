﻿

using System.Text.Json.Serialization;

namespace LibraryManager.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        // Foreign key for the Author
        public Author? Author { get; set; }
    }
}
