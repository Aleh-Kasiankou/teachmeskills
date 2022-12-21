using System;
using System.Linq;
using HelpDesk.Persistence;
using HelpDesk.Services.TicketUpdateHandler;
using HelpDesk.Services.TicketUpdateHandler.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HelpDeskDbContext _dbContext;
        private readonly ITicketUpdateHandler _ticketUpdateHandler;

        public CustomerController(HelpDeskDbContext dbContext, ITicketUpdateHandler ticketUpdateHandler)
        {
            _dbContext = dbContext;
            _ticketUpdateHandler = ticketUpdateHandler;
        }

        // GET
        public IActionResult Index()
        {
            return View(_dbContext.SupportRequests);
        }

        [HttpGet]
        public IActionResult TicketDetails(Guid id)
        {
            var ticket = _dbContext.SupportRequests
                .FirstOrDefault(x => x.SupportRequestId == id);

            if (ticket != null)
            {
                return View(ticket);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult TicketDetails([FromForm] CustomerTicketUpdateRequest fieldsToUpdate)
        {
            _ticketUpdateHandler.UpdateTicketFields(fieldsToUpdate);
            return RedirectToRoute(TicketDetails(fieldsToUpdate.SupportRequestId));
        }
    }
}