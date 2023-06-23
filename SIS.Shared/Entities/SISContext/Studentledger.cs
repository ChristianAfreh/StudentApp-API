using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentledger
    {
        public Guid Id { get; set; }
        public string Studentid { get; set; }
        public int Serialnumber { get; set; }
        public DateTime Transdate { get; set; }
        public string Transactiontype { get; set; }
        public string Currencyid { get; set; }
        public decimal Amount { get; set; }
        public decimal Bal { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}
