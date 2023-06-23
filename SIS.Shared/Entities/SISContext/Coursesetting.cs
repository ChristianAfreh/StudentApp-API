using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Coursesetting
    {
        public int Programmestreamid { get; set; }
        public int Optionid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public int Minsemcredit { get; set; }
        public int Maxsemcredit { get; set; }
        public int? Minoptcourse1 { get; set; }
        public int? Minoptcourse2 { get; set; }
        public int? Minoptcourse3 { get; set; }
        public int? Maxoptcourse1 { get; set; }
        public int? Maxoptcourse2 { get; set; }
        public int? Maxoptcourse3 { get; set; }

        public virtual Programmeoption Programmeoption { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
