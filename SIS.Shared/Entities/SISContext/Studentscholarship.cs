using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentscholarship
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Scholarshiptypeid { get; set; }
        public int Acadyear { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual Scholarshiptype Scholarshiptype { get; set; }
    }
}
