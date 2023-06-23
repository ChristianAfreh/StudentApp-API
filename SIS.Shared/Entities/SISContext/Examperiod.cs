using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Examperiod
    {
        public Examperiod()
        {
            Examtimetables = new HashSet<Examtimetable>();
        }

        public int Examperiodid { get; set; }
        public TimeSpan? Starttime { get; set; }
        public TimeSpan? Endtime { get; set; }
        public int? Daysessionid { get; set; }

        public virtual Daysession Daysession { get; set; }
        public virtual ICollection<Examtimetable> Examtimetables { get; set; }
    }
}
