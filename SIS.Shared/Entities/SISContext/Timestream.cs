using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Timestream
    {
        public Timestream()
        {
            Programmestreams = new HashSet<Programmestream>();
        }

        public int Timestreamid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Programmestream> Programmestreams { get; set; }
    }
}
