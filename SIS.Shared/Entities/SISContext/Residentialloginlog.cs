using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residentialloginlog
    {
        public long Id { get; set; }
        public string Studentid { get; set; }
        public string Pin { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Username { get; set; }
    }
}
