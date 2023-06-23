using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class DelstudentsWithcwa20212
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public double? Cwa { get; set; }
    }
}
