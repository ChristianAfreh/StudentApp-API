using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmesemester
    {
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public DateTime? Registrationstartdate { get; set; }
        public DateTime? Registrationenddate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Examstartdate { get; set; }
        public DateTime? Examenddate { get; set; }
        public bool Resultsapproved { get; set; }
        public bool Changeoption { get; set; }
        public bool Changecampus { get; set; }
        public string Resultsapprovedby { get; set; }
        public DateTime? Resultsapproveddate { get; set; }

        public virtual Programmestream Programmestream { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
