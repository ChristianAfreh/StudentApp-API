using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Calendardetail
    {
        public int Calendarid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime? Registrationstartdate { get; set; }
        public DateTime? Registrationenddate { get; set; }
        public DateTime? Billdate { get; set; }
        public DateTime? Feepaymentstartdate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Examstartdate { get; set; }
        public DateTime? Examenddate { get; set; }
        public bool? Isdefault { get; set; }
        public string Description { get; set; }

        public virtual Calendar Calendar { get; set; }
    }
}
