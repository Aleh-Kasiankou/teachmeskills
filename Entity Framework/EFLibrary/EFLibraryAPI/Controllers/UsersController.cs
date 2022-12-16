using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFLibraryPersistence;
using EFLibraryServices.DbCleaner;
using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly DbCleaner _dbCleaner;

        public UsersController(DbCleaner dbCleaner)
        {
            _dbCleaner = dbCleaner;
        }

        [HttpDelete("without_books")] 
        // Couldn't figure out the proper URL template
        public async Task<IEnumerable<string>> DeleteUsersWithoutBooks()
        {
            return await _dbCleaner.DeleteUsersWithoutBooks();

        }
    }
}