using System;
using HelpDesk.Persistence.Models.Enums;

namespace HelpDesk.Persistence.Models
{
    public class SupportRequest
    {
        public Guid SupportRequestId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public SupportRequestStatus RequestStatus { get; set; } = SupportRequestStatus.New;
        
        public Guid SupportSpecialistId { get; set; }
        public virtual SupportSpecialist SupportSpecialist { get; set; }

        public Guid SupportDepartmentId { get; set; }
        public virtual SupportDepartment SupportDepartment { get; set; }
    }
}