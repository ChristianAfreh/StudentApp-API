using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentfeeclearancelog
    {
        public Guid Id { get; set; }
        public string Actiontaken { get; set; }
        public DateTime Actiontime { get; set; }
        public string Username { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime? Transdate { get; set; }
        public string Reason { get; set; }
    }
}
