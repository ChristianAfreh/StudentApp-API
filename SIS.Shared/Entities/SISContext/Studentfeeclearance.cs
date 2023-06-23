using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentfeeclearance
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime? Transdate { get; set; }
        public string Reason { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }

        public virtual Programmestream Programmestream { get; set; }
    }
}
