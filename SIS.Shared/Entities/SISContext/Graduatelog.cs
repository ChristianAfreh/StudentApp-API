using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduatelog
    {
        public long Logid { get; set; }
        public Guid Id { get; set; }
        public Guid Graduationstreamid { get; set; }
        public string Studentid { get; set; }
        public string Indexno { get; set; }
        public int Programmestreamid { get; set; }
        public decimal? Cwa { get; set; }
        public DateTime Effectivedate { get; set; }
        public string Programmeaward { get; set; }
        public string Longprogrammename { get; set; }
        public string Shortprogrammename { get; set; }
        public string Specialization { get; set; }
        public int Awardclassid { get; set; }
        public string Awardclassname { get; set; }
        public int Awardclassrank { get; set; }
        public string Departmentname { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public Guid? Batchid { get; set; }
        public bool Isapproved { get; set; }
        public string Approvedby { get; set; }
        public DateTime? Timeapproved { get; set; }
        public string Actiontaken { get; set; }
        public DateTime Actiontime { get; set; }
        public string Clientnetaddress { get; set; }
        public string Hostname { get; set; }
        public string Username { get; set; }
    }
}
