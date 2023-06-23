using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class NumbersCopy
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Statistic { get; set; }
        public int? StatValue { get; set; }
        public string StatCode { get; set; }
    }
}
