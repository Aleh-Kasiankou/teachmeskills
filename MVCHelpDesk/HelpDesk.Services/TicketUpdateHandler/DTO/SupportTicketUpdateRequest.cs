using System;
using HelpDesk.Persistence.Models;
using HelpDesk.Persistence.Models.Enums;

namespace HelpDesk.Services.TicketUpdateHandler.DTO
{
    public class SupportTicketUpdateRequest
    {
        public Guid SupportRequestId { get; set; }
        public SupportRequestStatus RequestStatus { get; set; } = SupportRequestStatus.New;
        public string SupportSpecialist { get; set; }
        public string SupportDepartment { get; set; }
    }
}