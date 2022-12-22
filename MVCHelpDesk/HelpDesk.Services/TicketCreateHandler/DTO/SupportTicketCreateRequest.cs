using System;
using HelpDesk.Persistence.Models.Enums;

namespace HelpDesk.Services.TicketCreateHandler.DTO
{
    public class SupportTicketCreateRequest
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public SupportRequestStatus RequestStatus { get; set; } = SupportRequestStatus.New;
        public string SupportDepartmentId { get; set; }
    }
}