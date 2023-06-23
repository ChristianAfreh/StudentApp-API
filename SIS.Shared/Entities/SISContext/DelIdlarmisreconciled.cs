using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class DelIdlarmisreconciled
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public DateTime Transdate { get; set; }
        public decimal Amount { get; set; }
        public string Dr { get; set; }
        public string Cru { get; set; }
        public string Crp { get; set; }
        public string Transid { get; set; }
        public string Oline { get; set; }
        public string Oid { get; set; }
    }
}
