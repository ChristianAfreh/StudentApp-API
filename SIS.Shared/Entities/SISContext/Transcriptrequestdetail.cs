using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Transcriptrequestdetail
    {
        public Guid Id { get; set; }
        public int Requestid { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public DateTime Transdate { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }
        public string Add5 { get; set; }
        public string Countryid { get; set; }
        public int? Copies { get; set; }
        public bool Isstudentcopy { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Updatedby { get; set; }

        public virtual Country Country { get; set; }
        public virtual Transcriptrequest Transcriptrequest { get; set; }
    }
}
