using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentprogramme20220218
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Optionid { get; set; }
        public string Indexno { get; set; }
        public int? Mincredits { get; set; }
        public DateTime? Graduationdate { get; set; }
        public DateTime? Datecompleted { get; set; }
        public int? Admissionlevelid { get; set; }
        public int? Admissionmonth { get; set; }
        public int Admissionyear { get; set; }
        public int Acadyearenrolled { get; set; }
        public int? Semenrolled { get; set; }
        public int? Aggregateobtained { get; set; }
        public int? Feecategoryid { get; set; }
        public int? Finalyear { get; set; }
        public int? Finalsem { get; set; }
        public int? Classid { get; set; }
        public int? Campusid { get; set; }
        public bool? Isfeepaying { get; set; }
        public int? Feeclassificationid { get; set; }
        public bool Isresidential { get; set; }
        public bool? Autoadmitted { get; set; }
        public int? Sourceid { get; set; }
        public string Fileno { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public Guid? Sourcerowid { get; set; }
        public Guid? Sourcerowguid { get; set; }
        public Guid Id { get; set; }
        public int? Tagid { get; set; }
        public DateTime? Expirydate { get; set; }
        public DateTime? Expectedcompletiondate { get; set; }
    }
}
