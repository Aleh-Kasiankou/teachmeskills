using System;
using System.Collections;
using System.Collections.Generic;

namespace EFLibraryPersistence.Models
{
    public class Book
    {
        public Guid BookId { get; set; }

        public string Name { get; set; }

        public Guid AuthorId { get; set; }

        public int Year { get; set; }
        public IEnumerable<UserBook> UserBooks { get; set; }
        public virtual Author Author { get; set; }
    }
}