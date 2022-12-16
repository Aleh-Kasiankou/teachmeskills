using System;
using System.Linq;
using EFLibraryPersistence;

namespace EFLibraryServices.BookReturnHandler
{
    public class BookReturnHandler
    {
        private readonly EfLibraryDbContext _dbContext;

        public BookReturnHandler(EfLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void ReturnBook(BookReturnRequest bookReturnRequest)
        {
            var userBookToRemove = _dbContext.UserBooks.FirstOrDefault(ub =>
                ub.User.Email == bookReturnRequest.UserEmail && ub.Book.Name == bookReturnRequest.BookName);

            if (userBookToRemove != null)
            {
                _dbContext.UserBooks.Remove(userBookToRemove);
                _dbContext.SaveChanges();
                return;
            }

            throw new ArgumentException(
                $"The user {bookReturnRequest.UserEmail} hasn't borrowed the book: {bookReturnRequest.BookName}");
        }
    }
}