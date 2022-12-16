using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFLibraryServices.BookReturnHandler;
using EFLibraryServices.BorrowedBookTracker;
using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("borrowed_books")]
    public class BorrowedBooksController : ControllerBase
    {
        private readonly BorrowedBookTracker _borrowedBookTracker;
        private readonly BookReturnHandler _bookReturnHandler;
        
        public BorrowedBooksController(BorrowedBookTracker borrowedBookTracker, BookReturnHandler bookReturnHandler)
        {
            _borrowedBookTracker = borrowedBookTracker;
            _bookReturnHandler = bookReturnHandler;
        }
        
        [HttpGet]
        public async Task<IEnumerable<BorrowedBook>> Get()
        {
            return await _borrowedBookTracker.GetListOfBorrowedBooks();
        }
        
        [HttpDelete]
        public async Task<IActionResult> ReturnBook([FromBody] BookReturnRequest bookReturnRequest)
        {
            try
            {
                await _bookReturnHandler.ReturnBook(bookReturnRequest);
                return NoContent();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}