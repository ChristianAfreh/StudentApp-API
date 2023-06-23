using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feeitemschedule
    {
        public int Feeitemid { get; set; }
        public int Feecategoryid { get; set; }
        public string Currencyid { get; set; }
        public decimal? Amount { get; set; }
        public bool Isexactamountrequired { get; set; }
        public decimal? Minamount { get; set; }
        public decimal? Maxamount { get; set; }
    }
}
