using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class DelStudentregisteredWhileowingMsgWithcheck
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public double Amountpaidsem { get; set; }
        public decimal? StudentFeeBalance { get; set; }
        public decimal? StudentSemFeeBalance { get; set; }
        public double StudentMinPaymentAmountRequired { get; set; }
        public decimal? StudentBill4Acadyear { get; set; }
        public string Resultmessage { get; set; }
    }
}
