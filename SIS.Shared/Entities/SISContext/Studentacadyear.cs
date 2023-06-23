using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentacadyear
    {
        public Studentacadyear()
        {
            Studentsemesters = new HashSet<Studentsemester>();
        }

        public Guid Id { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int? Yr { get; set; }
        public int Acadlevelid { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Txtdata { get; set; }
        public bool? Isactive { get; set; }
        public int? Yr2 { get; set; }
        public int? Feecategoryid { get; set; }

        public virtual Academiclevel Acadlevel { get; set; }
        public virtual Studentprogramme Studentprogramme { get; set; }
        public virtual ICollection<Studentsemester> Studentsemesters { get; set; }
    }
}
