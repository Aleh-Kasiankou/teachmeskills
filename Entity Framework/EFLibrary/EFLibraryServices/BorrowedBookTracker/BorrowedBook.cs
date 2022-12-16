using System;

namespace EFLibraryServices.BorrowedBookTracker
{
    public class BorrowedBook
    {
        public string UserFullName { get; set; }
        public DateTime UserBirthDate { get; set; }
        public string BookName { get; set; }
        public int BookYear { get; set; }
        public string AuthorFullName { get; set; }
    }
}