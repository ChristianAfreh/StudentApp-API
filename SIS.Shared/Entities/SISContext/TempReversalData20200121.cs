using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempReversalData20200121
    {
        public string Bank { get; set; }
        public DateTime? Date { get; set; }
        public string Details { get; set; }
        public double? Studentid { get; set; }
        public double? Receiptid { get; set; }
        public double? Amount { get; set; }
        public double? Correctreceiptid { get; set; }
    }
}
