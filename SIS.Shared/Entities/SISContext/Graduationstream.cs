using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationstream
    {
        public Guid Graduationstreamid { get; set; }
        public int Acadyear { get; set; }
        public string Graduationstreamname { get; set; }
        public int Graduationnumber { get; set; }
        public int Graduationtypeid { get; set; }
        public DateTime? Effectivedate { get; set; }
        public bool? Isclosed { get; set; }
        public int? Graduationstreamstatusid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }

        public virtual Graduationtype Graduationtype { get; set; }
        public virtual StudentGraduationDate StudentGraduationDate { get; set; }
    }
}
