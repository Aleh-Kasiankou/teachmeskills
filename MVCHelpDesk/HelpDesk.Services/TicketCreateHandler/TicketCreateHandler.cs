using System;
using HelpDesk.Persistence;
using HelpDesk.Persistence.Models;
using HelpDesk.Persistence.Models.Enums;
using HelpDesk.Services.TicketAutoAssigner;
using HelpDesk.Services.TicketCreateHandler.DTO;

namespace HelpDesk.Services.TicketCreateHandler
{
    public class TicketCreateHandler : ITicketCreateHandler
    {
        private readonly HelpDeskDbContext _dbContext;
        private readonly ITicketAutoAssigner _ticketAutoAssigner;

        public TicketCreateHandler(HelpDeskDbContext dbContext, ITicketAutoAssigner ticketAutoAssigner)
        {
            _dbContext = dbContext;
            _ticketAutoAssigner = ticketAutoAssigner;
        }

        public void CreateTicket(CustomerTicketCreateRequest newTicket)
        {
            var ticket = new SupportRequest()
            {
                Subject = newTicket.Subject,
                Description = newTicket.Description,
                RequestStatus = SupportRequestStatus.New
            };
            
            ticket = _ticketAutoAssigner.AssignTicket(ticket);
            _dbContext.SupportRequests.Add(ticket);
            _dbContext.SaveChanges();
        }
        
        public void CreateTicket(SupportTicketCreateRequest newTicket)
        {
            var ticket = new SupportRequest()
            {
                Subject = newTicket.Subject,
                Description = newTicket.Description,
                RequestStatus = newTicket.RequestStatus,
                SupportDepartmentId = Guid.Parse(newTicket.SupportDepartmentId)
            };
            ticket = _ticketAutoAssigner.AssignTicket(ticket);
            
            _dbContext.SupportRequests.Add(ticket);
            _dbContext.SaveChanges();
        }
    }
}