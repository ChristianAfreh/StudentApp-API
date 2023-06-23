using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Billactivitylog
    {
        public long Id { get; set; }
        public int Deletecount { get; set; }
        public int Insertcount { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}
