using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Gradingsystemclass
    {
        public int Id { get; set; }
        public int Gradingid { get; set; }
        public double Lowerlimit { get; set; }
        public double? Upperlimit { get; set; }
        public string Award { get; set; }
        public string Awardshortcode { get; set; }
        public int? Sortno { get; set; }
        public int? Awardclassid { get; set; }

        public virtual Awardclass Awardclass { get; set; }
        public virtual Gradingsystem Grading { get; set; }
    }
}
