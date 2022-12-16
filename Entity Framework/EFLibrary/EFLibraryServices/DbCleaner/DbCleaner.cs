using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFLibraryPersistence;
using Microsoft.EntityFrameworkCore;

namespace EFLibraryServices.DbCleaner
{
    public class DbCleaner
    {
        private readonly EfLibraryDbContext _dbContext;
        
        public DbCleaner(EfLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<string>> DeleteUsersWithoutBooks()
        {
            var usersToRemove = _dbContext.Users.
                Where(u => !_dbContext.UserBooks.
                    Select(ub => ub.User).
                    Any(x => x == u)).ToArrayAsync();
            
            _dbContext.Users.RemoveRange(await usersToRemove);
            await _dbContext.SaveChangesAsync();

            return (await usersToRemove).Select(u => u.FirstName + " " + u.LastName).ToArray();

        }
    }
}