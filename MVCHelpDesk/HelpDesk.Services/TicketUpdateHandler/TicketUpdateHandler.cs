using System;
using System.Linq;
using HelpDesk.Persistence;
using HelpDesk.Persistence.Models.Enums;
using HelpDesk.Services.TicketUpdateHandler.DTO;

namespace HelpDesk.Services.TicketUpdateHandler
{
    public class TicketUpdateHandler : ITicketUpdateHandler
    {
        private readonly HelpDeskDbContext _dbContext;

        public TicketUpdateHandler(HelpDeskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void UpdateTicketFields(CustomerTicketUpdateRequest fieldsToUpdate)
        {
            var ticket =
                _dbContext.SupportRequests
                    .FirstOrDefault(x => x.SupportRequestId == fieldsToUpdate.SupportRequestId);

            if (ticket != null)
            {
                ticket.Subject = fieldsToUpdate.Subject;
                ticket.Description = fieldsToUpdate.Description;

                if (fieldsToUpdate.RequestStatus == SupportRequestStatus.Closed)
                {
                    ticket.RequestStatus = fieldsToUpdate.RequestStatus;
                }

                _dbContext.SaveChanges();
                return;
            }

            Console.WriteLine(fieldsToUpdate.SupportRequestId);
        }

        public void UpdateTicketFields(SupportTicketUpdateRequest fieldsToUpdate)
        {
            var ticket =
                _dbContext.SupportRequests
                    .FirstOrDefault(x => x.SupportRequestId == fieldsToUpdate.SupportRequestId);

            if (ticket != null)
            {
                ticket.SupportDepartmentId = Guid.Parse(fieldsToUpdate.SupportDepartment);
                ticket.RequestStatus = fieldsToUpdate.RequestStatus;
                ticket.SupportSpecialistId = Guid.Parse(fieldsToUpdate.SupportSpecialist);
            }


            _dbContext.SaveChanges();
        }
    }
}
