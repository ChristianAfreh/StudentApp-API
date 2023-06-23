using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Taggedstudentlog
    {
        public long Logid { get; set; }
        public int? Id { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Programmestream { get; set; }
        public int? Acadyear { get; set; }
        public int? Sem { get; set; }
        public int? Yr { get; set; }
        public int Tagid { get; set; }
        public string Tag { get; set; }
        public string Reason { get; set; }
        public string Actiontaken { get; set; }
        public DateTime? Actiontime { get; set; }
        public string Username { get; set; }
    }
}
