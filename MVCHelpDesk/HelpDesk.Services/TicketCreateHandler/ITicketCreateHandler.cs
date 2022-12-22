using HelpDesk.Services.TicketCreateHandler.DTO;

namespace HelpDesk.Services.TicketCreateHandler
{
    public interface ITicketCreateHandler
    {
        void CreateTicket(CustomerTicketCreateRequest createRequest);
        void CreateTicket(SupportTicketCreateRequest createRequest);
    }
}