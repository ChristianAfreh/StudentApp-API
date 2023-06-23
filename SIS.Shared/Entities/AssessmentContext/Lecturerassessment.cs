using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Lecturerassessment
    {
        public Lecturerassessment()
        {
            Responses = new HashSet<Response>();
        }

        public int Assessmentid { get; set; }
        public int Setid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Staffid { get; set; }
        public string Coursecode { get; set; }

        public virtual Questionset Set { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
    }
}
