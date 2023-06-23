using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feethreshold
    {
        public int Id { get; set; }
        public decimal? Thresholdvalue { get; set; }
        public double? Thresholdpercent { get; set; }
        public int? Collegeid { get; set; }
    }
}
