using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Courseregistrationexception
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Reason { get; set; }
        public string Username { get; set; }
        public DateTime Datetimeinserted { get; set; }

        public virtual Programmestream Programmestream { get; set; }
        public virtual Student Student { get; set; }
    }
}
