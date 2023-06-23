using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Transcriptrequeststatus
    {
        public Transcriptrequeststatus()
        {
            Transcriptrequests = new HashSet<Transcriptrequest>();
        }

        public int Transstatusid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Transcriptrequest> Transcriptrequests { get; set; }
    }
}
