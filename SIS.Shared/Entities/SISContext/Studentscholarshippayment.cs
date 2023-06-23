using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentscholarshippayment
    {
        public Guid Studentscholarshippaymentid { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Scholarshiptypeid { get; set; }
        public double Amountpaid { get; set; }
        public DateTime? Datepaid { get; set; }
    }
}
