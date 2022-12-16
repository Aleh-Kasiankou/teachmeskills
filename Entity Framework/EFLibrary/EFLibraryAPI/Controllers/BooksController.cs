using System.Collections.Generic;
using EFLibraryServices.BorrowedBookTracker;
using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : ControllerBase
    {
        private readonly BorrowedBookTracker _borrowedBookTracker;
        
        public BooksController(BorrowedBookTracker borrowedBookTracker)
        {
            _borrowedBookTracker = borrowedBookTracker;
        }
        
        [HttpGet("borrowed")]
        public IEnumerable<BorrowedBook> Get()
        {
            return _borrowedBookTracker.GetListOfBorrowedBooks();
        }
    }
}