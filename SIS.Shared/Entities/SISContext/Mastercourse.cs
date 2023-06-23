using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Mastercourse
    {
        public Mastercourse()
        {
            Academicrecords = new HashSet<Academicrecord>();
            Examverifications = new HashSet<Examverification>();
            Gradingsystemnonscoringcourses = new HashSet<Gradingsystemnonscoringcourse>();
            Gradingsystemscoringexceptions = new HashSet<Gradingsystemscoringexception>();
            Programmecourses = new HashSet<Programmecourse>();
        }

        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
        public int? Departmentid { get; set; }
        public int? Graduatetypeid { get; set; }
        public bool Isopenelective { get; set; }
        public int? Sourceid { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public int? Sem { get; set; }

        public virtual Department Department { get; set; }
        public virtual Graduatetype Graduatetype { get; set; }
        public virtual ICollection<Academicrecord> Academicrecords { get; set; }
        public virtual ICollection<Examverification> Examverifications { get; set; }
        public virtual ICollection<Gradingsystemnonscoringcourse> Gradingsystemnonscoringcourses { get; set; }
        public virtual ICollection<Gradingsystemscoringexception> Gradingsystemscoringexceptions { get; set; }
        public virtual ICollection<Programmecourse> Programmecourses { get; set; }
    }
}
