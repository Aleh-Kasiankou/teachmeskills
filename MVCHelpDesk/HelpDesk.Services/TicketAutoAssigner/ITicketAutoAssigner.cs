using HelpDesk.Persistence.Models;

namespace HelpDesk.Services.TicketAutoAssigner
{
    public interface ITicketAutoAssigner
    {
        SupportRequest AssignTicket(SupportRequest ticket);
    }
}