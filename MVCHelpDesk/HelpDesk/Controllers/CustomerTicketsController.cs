using System;
using System.Linq;
using HelpDesk.Persistence;
using HelpDesk.Services.TicketCreateHandler;
using HelpDesk.Services.TicketCreateHandler.DTO;
using HelpDesk.Services.TicketUpdateHandler;
using HelpDesk.Services.TicketUpdateHandler.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class CustomerTicketsController : Controller
    {
        private readonly HelpDeskDbContext _dbContext;
        private readonly ITicketCreateHandler _ticketCreateHandler;
        private readonly ITicketUpdateHandler _ticketUpdateHandler;

        public CustomerTicketsController(HelpDeskDbContext dbContext, ITicketUpdateHandler ticketUpdateHandler,
            ITicketCreateHandler ticketCreateHandler)
        {
            _dbContext = dbContext;
            _ticketUpdateHandler = ticketUpdateHandler;
            _ticketCreateHandler = ticketCreateHandler;
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

        public IActionResult NewTicket()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewTicket([FromForm] CustomerTicketCreateRequest newTicket)
        {
            _ticketCreateHandler.CreateTicket(newTicket);
            return RedirectToAction("Index");
        }

        public IActionResult TicketCounter()
        {
            return PartialView();
        }
    }
}