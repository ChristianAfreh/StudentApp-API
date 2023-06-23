using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Coursestatus
    {
        public Coursestatus()
        {
            Academicrecords = new HashSet<Academicrecord>();
        }

        public int Coursestatusid { get; set; }
        public string Shortcode { get; set; }
        public string Name { get; set; }
        public bool Usemark2computeaverage { get; set; }

        public virtual ICollection<Academicrecord> Academicrecords { get; set; }
    }
}
