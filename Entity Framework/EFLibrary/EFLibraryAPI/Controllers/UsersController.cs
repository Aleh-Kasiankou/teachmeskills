using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<string> DeleteUsersWithoutBooks()
        {
            return _dbCleaner.DeleteUsersWithoutBooks();

        }
    }
}