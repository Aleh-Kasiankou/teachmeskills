using System;
using System.Collections.Generic;

namespace EFLibraryPersistence.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } 
        public DateTime ExpiredDate { get; set; }
        public IEnumerable<UserBook> UserBooks { get; set; }

    }
}