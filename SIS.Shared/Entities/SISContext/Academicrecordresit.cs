using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Academicrecordresit
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursecode { get; set; }
        public int Id { get; set; }
        public int Yr { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
        public int? Coursestatusid { get; set; }
        public double? Totalmark { get; set; }
        public double? Numeq { get; set; }
        public string Grade { get; set; }
        public int Istrail { get; set; }
        public int Iscalc { get; set; }
        public DateTime? Timeinserted { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Insertedby { get; set; }
        public string Updatedby { get; set; }
        public int? Acadrank { get; set; }
    }
}
