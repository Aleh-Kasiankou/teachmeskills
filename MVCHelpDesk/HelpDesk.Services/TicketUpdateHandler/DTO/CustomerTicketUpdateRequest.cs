using System;
using HelpDesk.Persistence.Models.Enums;

namespace HelpDesk.Services.TicketUpdateHandler.DTO
{
    public class CustomerTicketUpdateRequest
    {
        public Guid SupportRequestId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public SupportRequestStatus RequestStatus { get; set; } = SupportRequestStatus.New;
    }
}