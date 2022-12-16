using System;
using System.Collections.Generic;
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
        public IEnumerable<BorrowedBook> Get()
        {
            return _borrowedBookTracker.GetListOfBorrowedBooks();
        }
        
        [HttpDelete]
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