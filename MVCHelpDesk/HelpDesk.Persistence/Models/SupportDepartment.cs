using System;
using System.Collections.Generic;

namespace HelpDesk.Persistence.Models
{
    public class SupportDepartment
    {
        public Guid SupportDepartmentId { get; set; }
        public string Name { get; set; }
        
        public virtual IEnumerable<SupportSpecialist> SupportSpecialists { get; set; }
        public virtual IEnumerable<SupportRequest> SupportRequests { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}