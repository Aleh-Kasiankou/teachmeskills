using System.Collections.Generic;
using System.Linq;
using EFLibraryPersistence;

namespace EFLibraryServices.DbCleaner
{
    public class DbCleaner
    {
        private readonly EfLibraryDbContext _dbContext;
        
        public DbCleaner(EfLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<string> DeleteUsersWithoutBooks()
        {
            var usersToRemove = _dbContext.Users.
                Where(u => !_dbContext.UserBooks.
                    Select(ub => ub.User).
                    Any(x => x == u)).ToArray();
            
            _dbContext.Users.RemoveRange(usersToRemove);
            _dbContext.SaveChanges();

            return usersToRemove.Select(u => u.FirstName + " " + u.LastName).ToArray();

        }
    }
}