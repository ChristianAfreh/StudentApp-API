using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Examtimetable
    {
        public string Coursecode { get; set; }
        public int Examperiodid { get; set; }
        public int Yr { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime? Examdate { get; set; }

        public virtual Examperiod Examperiod { get; set; }
        public virtual Examtimetabledetail Examtimetabledetail { get; set; }
    }
}
