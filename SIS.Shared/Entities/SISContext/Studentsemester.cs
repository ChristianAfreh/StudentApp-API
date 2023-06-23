using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentsemester
    {
        public Studentsemester()
        {
            Academicrecords = new HashSet<Academicrecord>();
            Studentfeeexemptions = new HashSet<Studentfeeexemption>();
            Studentrefunds = new HashSet<Studentrefund>();
        }

        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public bool? Autopromoted { get; set; }
        public int? Sourceid { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public int? Preregistrationstatus { get; set; }
        public bool? Iscurrent { get; set; }
        public Guid? Sourcerowguid { get; set; }
        public Guid Id { get; set; }
        public string Metadata { get; set; }
        public int? Yr2 { get; set; }

        public virtual Academiclevel Acadlevel { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Studentacadyear Studentacadyear { get; set; }
        public virtual Studentfeecategory Studentfeecategory { get; set; }
        public virtual Taggedstudent Taggedstudent { get; set; }
        public virtual ICollection<Academicrecord> Academicrecords { get; set; }
        public virtual ICollection<Studentfeeexemption> Studentfeeexemptions { get; set; }
        public virtual ICollection<Studentrefund> Studentrefunds { get; set; }
    }
}
