using HelpDesk.Persistence;
using HelpDesk.Services.TicketUpdateHandler.DTO;

namespace HelpDesk.Services.TicketUpdateHandler
{
    public interface ITicketUpdateHandler
    {
        void UpdateTicketFields(CustomerTicketUpdateRequest fieldsToUpdate);
        void UpdateTicketFields(SupportTicketUpdateRequest fieldsToUpdate);
    }
}