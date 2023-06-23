using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Gradingsystemscoring
    {
        public int Id { get; set; }
        public int Gradingid { get; set; }
        public double Lowerlimit { get; set; }
        public double? Upperlimit { get; set; }
        public string Grade { get; set; }
        public double? Numeq { get; set; }
        public bool Istrail { get; set; }
        public string Remark { get; set; }

        public virtual Gradingsystem Grading { get; set; }
    }
}
