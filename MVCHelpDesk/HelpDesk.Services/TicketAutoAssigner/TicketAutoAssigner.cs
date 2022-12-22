using System;
using System.Linq;
using HelpDesk.Persistence;
using HelpDesk.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Services.TicketAutoAssigner
{
    public class TicketAutoAssigner : ITicketAutoAssigner
    {
        private readonly HelpDeskDbContext _dbContext;

        public TicketAutoAssigner(HelpDeskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SupportRequest AssignTicket(SupportRequest ticket)
        {
            if (ticket.SupportDepartment == null)
            {
                ticket = AssignDepartment(ticket);
            }

            ticket = AssignAgent(ticket);   

            return ticket;
        }

        private SupportRequest AssignDepartment(SupportRequest ticket)
        {
            var deps = _dbContext.SupportDepartments
                .Include(x => x.SupportSpecialists)
                .ToList();

            if (deps.Count > 0)
            {
                var dep = deps[new Random().Next(0, deps.Count)];
                ticket.SupportDepartment = dep;
                ticket.SupportDepartmentId = dep.SupportDepartmentId;
            }

            return ticket;
        }

        private SupportRequest AssignAgent(SupportRequest ticket)
        {
            if (ticket.SupportDepartmentId != Guid.Empty)
            {
                var ticketDepartmentWithSpecialists =
                    _dbContext.SupportDepartments
                        .Include(x => x.SupportSpecialists)
                        .FirstOrDefault(x =>
                            x.SupportDepartmentId == ticket.SupportDepartmentId);
                
                if (ticketDepartmentWithSpecialists != null)
                {
                    var supportAgents = ticketDepartmentWithSpecialists.SupportSpecialists.ToList();
                    if (supportAgents.Count > 0)
                    {
                        var agent = supportAgents[new Random().Next(0, supportAgents.Count)];
                        ticket.SupportSpecialist = agent;
                    }
                }
            }

            else
            {
                throw new ArgumentException("Ticket doesn't have a support department ID");
            }

            return ticket;
        }
    }
}