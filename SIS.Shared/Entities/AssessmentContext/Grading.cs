using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Grading
    {
        public Grading()
        {
            Responsevalues = new HashSet<Responsevalue>();
        }

        public int Gradingid { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public decimal Lowerbound { get; set; }
        public decimal Upperbound { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Responsevalue> Responsevalues { get; set; }
    }
}
