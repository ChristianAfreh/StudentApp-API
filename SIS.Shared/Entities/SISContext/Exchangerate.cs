using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Exchangerate
    {
        public string Currencyid { get; set; }
        public DateTime Tdate { get; set; }
        public double Xrate { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
