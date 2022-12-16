using System;
using System.Linq;
using System.Threading.Tasks;
using EFLibraryPersistence;
using Microsoft.EntityFrameworkCore;

namespace EFLibraryServices.BookReturnHandler
{
    public class BookReturnHandler
    {
        private readonly EfLibraryDbContext _dbContext;

        public BookReturnHandler(EfLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ReturnBook(BookReturnRequest bookReturnRequest)
        {
            var userBookToRemove = _dbContext.UserBooks.FirstOrDefaultAsync(ub =>
                ub.User.Email == bookReturnRequest.UserEmail && ub.Book.Name == bookReturnRequest.BookName);

            if (await userBookToRemove != null)
            {
                _dbContext.UserBooks.Remove(await userBookToRemove);
                await _dbContext.SaveChangesAsync();
                return;
            }

            throw new ArgumentException(
                $"The user {bookReturnRequest.UserEmail} hasn't borrowed the book: {bookReturnRequest.BookName}");
        }
    }
}