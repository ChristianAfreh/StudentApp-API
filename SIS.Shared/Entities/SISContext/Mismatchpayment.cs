using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Mismatchpayment
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public string Transactionid { get; set; }
        public decimal Amountinsis { get; set; }
        public decimal Amountfromnsano { get; set; }
        public string Altransactionid { get; set; }
    }
}
