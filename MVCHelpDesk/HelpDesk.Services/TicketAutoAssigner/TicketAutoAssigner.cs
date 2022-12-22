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
            if (ticket.SupportDepartment != null)
            {
                var deps = _dbContext.SupportDepartments
                    .Include(x => x.SupportSpecialists)
                    .ToList();

                if (deps.Count > 0)
                {
                    var dep = deps[new Random().Next(0, deps.Count)];
                    ticket.SupportDepartment = dep;
                }
            }

            if (ticket.SupportDepartmentId != Guid.Empty)
            {
                var ticketDepartment =
                    _dbContext.SupportDepartments
                        .Include(x => x.SupportSpecialists)
                        .FirstOrDefault(x =>
                            x.SupportDepartmentId == ticket.SupportDepartmentId);
                if (ticketDepartment != null)
                {
                    var supportAgents = ticketDepartment.SupportSpecialists.ToList();
                    if (supportAgents.Count > 0)
                    {
                        var agent = supportAgents[new Random().Next(0, supportAgents.Count)];
                        ticket.SupportSpecialist = agent;
                    }
                }
            }

            return ticket;
        }
    }
}