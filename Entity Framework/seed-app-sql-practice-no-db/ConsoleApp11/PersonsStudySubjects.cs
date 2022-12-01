using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp11
{
    public partial class PersonsStudySubjects
    {
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }

        public virtual Persons Student { get; set; }
        public virtual StudySubjects Subject { get; set; }
    }
}
