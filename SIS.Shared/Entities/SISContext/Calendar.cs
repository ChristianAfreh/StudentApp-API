using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Calendar
    {
        public Calendar()
        {
            Calendardetails = new HashSet<Calendardetail>();
            Programmestreams = new HashSet<Programmestream>();
        }

        public int Calendarid { get; set; }
        public string Name { get; set; }
        public bool Isdefault { get; set; }

        public virtual ICollection<Calendardetail> Calendardetails { get; set; }
        public virtual ICollection<Programmestream> Programmestreams { get; set; }
    }
}
