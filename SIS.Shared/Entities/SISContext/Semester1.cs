using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Semester1
    {
        public Semester1()
        {
            AcademicSemesters = new HashSet<AcademicSemester>();
        }

        public int SemesterId { get; set; }
        public string SemesterName { get; set; }

        public virtual ICollection<AcademicSemester> AcademicSemesters { get; set; }
    }
}
