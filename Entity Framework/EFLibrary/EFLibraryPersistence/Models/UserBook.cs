using System;

namespace EFLibraryPersistence.Models
{
    public class UserBook
    {
        public Guid UserBookId { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }
}