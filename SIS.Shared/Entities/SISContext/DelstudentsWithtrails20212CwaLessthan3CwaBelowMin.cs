using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class DelstudentsWithtrails20212CwaLessthan3CwaBelowMin
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public double? Cwa { get; set; }
        public int? Counttrails { get; set; }
    }
}
