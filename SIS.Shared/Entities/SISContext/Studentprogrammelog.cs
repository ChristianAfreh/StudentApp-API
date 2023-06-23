using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentprogrammelog
    {
        public long Logid { get; set; }
        public int? Id { get; set; }
        public string Studentid { get; set; }
        public int? OldProgrammestreamid { get; set; }
        public int? NewProgrammestreamid { get; set; }
        public string Actiontaken { get; set; }
        public DateTime? Actiontime { get; set; }
        public string Username { get; set; }
        public string Clientnetaddress { get; set; }
    }
}
