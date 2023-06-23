using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Semestertype
    {
        public Semestertype()
        {
            Semesters = new HashSet<Semester>();
        }

        public int Sem { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Semester> Semesters { get; set; }
    }
}
