using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Transcriptrequest
    {
        public Transcriptrequest()
        {
            Transcriptrequestdetails = new HashSet<Transcriptrequestdetail>();
        }

        public int Requestid { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public DateTime Transdate { get; set; }
        public int? Transstatusid { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Updatedby { get; set; }

        public virtual Transcriptrequeststatus Transstatus { get; set; }
        public virtual ICollection<Transcriptrequestdetail> Transcriptrequestdetails { get; set; }
    }
}
