using System;

namespace EFLibraryPersistence.Models
{
    public class UserBook
    {
        public Guid UserBookId { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}