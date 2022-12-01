using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp11
{
    public partial class Addresses
    {
        public Addresses()
        {
            Persons = new HashSet<Persons>();
            Universities = new HashSet<Universities>();
        }

        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Persons> Persons { get; set; }
        public virtual ICollection<Universities> Universities { get; set; }
    }
}
