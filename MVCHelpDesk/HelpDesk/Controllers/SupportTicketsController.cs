using System;
using System.Linq;
using HelpDesk.Persistence;
using HelpDesk.Services.TicketCreateHandler;
using HelpDesk.Services.TicketCreateHandler.DTO;
using HelpDesk.Services.TicketUpdateHandler;
using HelpDesk.Services.TicketUpdateHandler.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Controllers
{
    public class SupportTicketsController : Controller
    {
        private readonly HelpDeskDbContext _dbContext;
        private readonly ITicketCreateHandler _ticketCreateHandler;
        private readonly ITicketUpdateHandler _ticketUpdateHandler;


        public SupportTicketsController(HelpDeskDbContext dbContext, ITicketUpdateHandler ticketUpdateHandler,
            ITicketCreateHandler ticketCreateHandler)
        {
            _dbContext = dbContext;
            _ticketUpdateHandler = ticketUpdateHandler;
            _ticketCreateHandler = ticketCreateHandler;
        }

        // GET
        public IActionResult Index()
        {
            return View(_dbContext.SupportRequests
                .Include(x => x.SupportDepartment)
                .Include(x => x.SupportSpecialist)
                .OrderBy(x => x.RequestStatus));
        }

        public IActionResult TicketDetails(Guid id)
        {
            var ticket = _dbContext.SupportRequests
                .Include(x => x.SupportDepartment)
                .ThenInclude(x => x.SupportSpecialists)
                .Include(x => x.SupportSpecialist)
                .FirstOrDefault(x => x.SupportRequestId == id);

            if (ticket != null)
            {
                ViewBag.SupportDepartments = _dbContext.SupportDepartments.Select(x => new SelectListItem
                {
                    Value = x.SupportDepartmentId.ToString(),
                    Text = x.Name,
                    Selected = x.SupportDepartmentId == ticket.SupportDepartmentId
                    // the line above is simpy ignored, so I added Order By clause
                }).OrderByDescending(x => x.Selected).ToArray();

                ViewBag.SupportSpecialists = ticket.SupportDepartment.SupportSpecialists.Select(x => new SelectListItem
                {
                    Value = x.SupportSpecialistId.ToString(),
                    Text = x.Name
                }).ToArray();

                return View(ticket);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult TicketDetails([FromForm] SupportTicketUpdateRequest fieldsToUpdate)
        {
            _ticketUpdateHandler.UpdateTicketFields(fieldsToUpdate);
            return RedirectToRoute(TicketDetails(fieldsToUpdate.SupportRequestId));
        }

        public IActionResult NewTicket()
        {
            ViewBag.SupportDepartments = _dbContext.SupportDepartments.Select(x => new SelectListItem
            {
                Value = x.SupportDepartmentId.ToString(),
                Text = x.Name,
            }).ToArray();


            return View(new SupportTicketCreateRequest());
        }

        [HttpPost]
        public IActionResult NewTicket([FromForm] SupportTicketCreateRequest newTicket)
        {
            _ticketCreateHandler.CreateTicket(newTicket);
            return RedirectToAction("Index");
        }
    }
}