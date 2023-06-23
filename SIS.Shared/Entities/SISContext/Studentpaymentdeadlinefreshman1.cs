using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentpaymentdeadlinefreshman1
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
    }
}
