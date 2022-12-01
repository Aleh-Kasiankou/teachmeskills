using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp11
{
    public partial class StudySubjects
    {
        public StudySubjects()
        {
            PersonsStudySubjects = new HashSet<PersonsStudySubjects>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UniversityId { get; set; }
        public Guid ProfessorId { get; set; }

        public virtual Persons Professor { get; set; }
        public virtual Universities University { get; set; }
        public virtual ICollection<PersonsStudySubjects> PersonsStudySubjects { get; set; }
    }
}
