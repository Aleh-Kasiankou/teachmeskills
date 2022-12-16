﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp11
{
    public partial class Universities
    {
        public Universities()
        {
            StudySubjects = new HashSet<StudySubjects>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public Guid? AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ICollection<StudySubjects> StudySubjects { get; set; }
    }
}
