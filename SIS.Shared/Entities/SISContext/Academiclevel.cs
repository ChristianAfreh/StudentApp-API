using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Academiclevel
    {
        public Academiclevel()
        {
            Academicrecordonlines = new HashSet<Academicrecordonline>();
            Academicrecords = new HashSet<Academicrecord>();
            Studentacadyears = new HashSet<Studentacadyear>();
            Studentsemesters = new HashSet<Studentsemester>();
        }

        public int Acadlevelid { get; set; }
        public string Name { get; set; }
        public int? Sort { get; set; }
        public string Altname { get; set; }

        public virtual ICollection<Academicrecordonline> Academicrecordonlines { get; set; }
        public virtual ICollection<Academicrecord> Academicrecords { get; set; }
        public virtual ICollection<Studentacadyear> Studentacadyears { get; set; }
        public virtual ICollection<Studentsemester> Studentsemesters { get; set; }
    }
}
