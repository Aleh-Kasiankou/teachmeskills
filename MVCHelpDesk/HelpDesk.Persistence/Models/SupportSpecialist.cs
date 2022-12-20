using System;
using System.Collections.Generic;

namespace HelpDesk.Persistence.Models
{
    public class SupportSpecialist
    {
        public Guid SupportSpecialistId { get; set; }
        public string Name { get; set; }
        
        public Guid SupportDepartmentId { get; set; }
        public virtual SupportDepartment SupportDepartment { get; set; }

        public virtual IEnumerable<SupportRequest> SupportRequests { get; set; }
    }
}