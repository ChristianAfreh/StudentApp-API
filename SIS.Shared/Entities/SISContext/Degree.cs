using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Degree
    {
        public int Degreeid { get; set; }
        public string Degreeshortname { get; set; }
        public string Degreelongname { get; set; }
        public int Degreetypeid { get; set; }

        public virtual Degreetype Degreetype { get; set; }
    }
}
