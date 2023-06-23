using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationfeeschedule
    {
        public int Id { get; set; }
        public Guid Graduationstreamid { get; set; }
        public string Currencyid { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}
