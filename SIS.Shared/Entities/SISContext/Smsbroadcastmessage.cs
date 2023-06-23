using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Smsbroadcastmessage
    {
        public int Messageid { get; set; }
        public string Messagebody { get; set; }
        public bool Isactive { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
    }
}
