using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Del2studentsWithtrails20212
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public int? Credit { get; set; }
        public int? Coursestatusid { get; set; }
        public string Totalmark { get; set; }
        public double? Numeq { get; set; }
        public string Grade { get; set; }
        public int? Acadlevelidtrail { get; set; }
        public int? Semtrail { get; set; }
        public int? Acadyeartrail { get; set; }
    }
}
