using System;
using System.Collections;
using System.Collections.Generic;

namespace EFLibraryPersistence.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}