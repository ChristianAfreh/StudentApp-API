using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Examinvigilator
    {
        public string Coursecode { get; set; }
        public int Invigilatorid { get; set; }
        public int Examperiodid { get; set; }
        public int Yr { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }

        public virtual Examtimetabledetail Examtimetabledetail { get; set; }
        public virtual Invigilator Invigilator { get; set; }
    }
}
