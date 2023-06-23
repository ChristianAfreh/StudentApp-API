using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Wspaymentaccepttransaction
    {
        public int Bankid { get; set; }
        public string Transactionid { get; set; }
        public DateTime Transdate { get; set; }
        public string Reason { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
