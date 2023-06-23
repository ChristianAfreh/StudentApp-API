using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Studentlog
    {
        public long Studentlogid { get; set; }
        public int Setid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Staffid { get; set; }
        public string Coursecode { get; set; }
        public string Studentid { get; set; }
        public DateTime Whensubmitted { get; set; }

        public virtual Questionset Set { get; set; }
    }
}
