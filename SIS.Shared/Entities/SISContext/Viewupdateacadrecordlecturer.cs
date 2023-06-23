using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewupdateacadrecordlecturer
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Coursecode { get; set; }
        public double? Camark { get; set; }
        public double? Endsemmark { get; set; }
        public double? Totalmark { get; set; }
        public double? Numeq { get; set; }
        public string Grade { get; set; }
        public int Istrail { get; set; }
        public int Iscalc { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Updatedby { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public int? Coursestatusid { get; set; }
    }
}
