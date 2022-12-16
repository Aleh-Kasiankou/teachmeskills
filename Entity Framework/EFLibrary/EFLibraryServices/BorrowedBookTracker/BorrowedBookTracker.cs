using System.Collections.Generic;
using System.Linq;
using EFLibraryPersistence;
using EFLibraryPersistence.Models;
using Microsoft.EntityFrameworkCore;

namespace EFLibraryServices.BorrowedBookTracker
{
    public class BorrowedBookTracker
    {
        private readonly EfLibraryDbContext _dbContext;

        public BorrowedBookTracker(EfLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BorrowedBook> GetListOfBorrowedBooks()
        {
            var userBooks = _dbContext.UserBooks
                .Include(ub => ub.User)
                .Include(ub => ub.Book)
                .ThenInclude(b => b.Author).ToList();

            var borrowedBooks = new List<BorrowedBook>();

            foreach (var userBook in userBooks)
            {
                var borrowedBook = MapUserBookToBorrowedBook(userBook);
                borrowedBooks.Add(borrowedBook);
            }

            return borrowedBooks;
        }

        private BorrowedBook MapUserBookToBorrowedBook(UserBook userBook)
        {
            var userFullName = userBook.User.FirstName + " " + userBook.User.LastName;
            var authorFullName = userBook.Book.Author.FirstName + " " + userBook.Book.Author.LastName;

            var borrowedBook = new BorrowedBook()
            {
                UserFullName = userFullName,
                UserBirthDate = userBook.User.BirthDate.Date,
                BookName = userBook.Book.Name,
                BookYear = userBook.Book.Year,
                AuthorFullName = authorFullName
            };

            return borrowedBook;
        }
    }
}