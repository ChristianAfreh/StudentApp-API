using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewStudenttranscript
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursecode { get; set; }
        public int Id { get; set; }
        public int? Acadlevelid { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
        public int? Coursestatusid { get; set; }
        public double? Totalmark { get; set; }
        public double? Numeq { get; set; }
        public string Grade { get; set; }
        public int Istrail { get; set; }
        public int Iscalc { get; set; }
    }
}
