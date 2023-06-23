using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Wspaymentsplit
    {
        public long Id { get; set; }
        public int Bankid { get; set; }
        public string Transactionid { get; set; }
        public int Feeitemid { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Clientnetaddress { get; set; }
        public string Studentid { get; set; }
        public bool Autosplit { get; set; }
    }
}
