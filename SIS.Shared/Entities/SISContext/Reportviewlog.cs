using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Reportviewlog
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Reportname { get; set; }
        public DateTime Actiontime { get; set; }
        public string Txtdata { get; set; }
    }
}
