using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduate
    {
        public Guid Id { get; set; }
        public Guid Graduationstreamid { get; set; }
        public string Studentid { get; set; }
        public string Indexno { get; set; }
        public int Programmestreamid { get; set; }
        public decimal? Cwa { get; set; }
        public DateTime Effectivedate { get; set; }
        public int? Departmentid { get; set; }
        public int? Facultyid { get; set; }
        public int Collegeid { get; set; }
        public string Programmeaward { get; set; }
        public string Longprogrammename { get; set; }
        public string Shortprogrammename { get; set; }
        public int? Optionid { get; set; }
        public string Specialization { get; set; }
        public int Awardclassid { get; set; }
        public string Awardclassname { get; set; }
        public int Awardclassrank { get; set; }
        public string Departmentname { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public Guid? Batchid { get; set; }
        public bool Isreviewed { get; set; }
        public string Reviewedby { get; set; }
        public DateTime? Timereviewed { get; set; }
        public bool Isapproved { get; set; }
        public string Approvedby { get; set; }
        public DateTime? Timeapproved { get; set; }
        public string Lastactiontaken { get; set; }
        public string Lastactionuser { get; set; }
        public DateTime? Lastactiontime { get; set; }
        public int? Campusid { get; set; }
        public string Campusname { get; set; }

        public virtual Graduationstream Graduationstream { get; set; }
        public virtual Studentprogramme Studentprogramme { get; set; }
        public virtual Studentprogramme StudentprogrammeNavigation { get; set; }
    }
}
