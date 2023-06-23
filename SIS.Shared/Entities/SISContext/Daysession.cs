using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Daysession
    {
        public Daysession()
        {
            Examperiods = new HashSet<Examperiod>();
            Lectureperiods = new HashSet<Lectureperiod>();
        }

        public int Daysessionid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Examperiod> Examperiods { get; set; }
        public virtual ICollection<Lectureperiod> Lectureperiods { get; set; }
    }
}
