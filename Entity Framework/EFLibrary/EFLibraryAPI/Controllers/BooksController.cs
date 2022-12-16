using System;
using System.Collections.Generic;
using EFLibraryServices.BookReturnHandler;
using EFLibraryServices.BorrowedBookTracker;
using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : ControllerBase
    {
        private readonly BorrowedBookTracker _borrowedBookTracker;
        private readonly BookReturnHandler _bookReturnHandler;
        
        public BooksController(BorrowedBookTracker borrowedBookTracker, BookReturnHandler bookReturnHandler)
        {
            _borrowedBookTracker = borrowedBookTracker;
            _bookReturnHandler = bookReturnHandler;
        }
        
        [HttpGet("borrowed")]
        public IEnumerable<BorrowedBook> Get()
        {
            return _borrowedBookTracker.GetListOfBorrowedBooks();
        }
        
        [HttpDelete("borrowed")]
        public IActionResult ReturnBook([FromBody] BookReturnRequest bookReturnRequest)
        {
            try
            {
                _bookReturnHandler.ReturnBook(bookReturnRequest);
                return NoContent();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}