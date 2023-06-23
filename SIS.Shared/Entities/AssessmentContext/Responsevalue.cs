using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Responsevalue
    {
        public int Responsevalueid { get; set; }
        public int Setid { get; set; }
        public int Value { get; set; }
        public string Label { get; set; }
        public string Grading { get; set; }
        public int Gradingid { get; set; }

        public virtual Grading GradingNavigation { get; set; }
    }
}
