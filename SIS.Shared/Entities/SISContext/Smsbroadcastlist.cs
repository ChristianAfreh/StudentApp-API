using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Smsbroadcastlist
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public string Phone { get; set; }
        public int Messageid { get; set; }
        public bool Isqueued { get; set; }
        public DateTime? Timequeued { get; set; }
        public DateTime Timeinserted { get; set; }

        public virtual Smsbroadcastmessage Message { get; set; }
        public virtual Student Student { get; set; }
    }
}
