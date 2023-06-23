using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Response
    {
        public long Responseid { get; set; }
        public int Assessmentid { get; set; }
        public int Responsevalueid { get; set; }
        public int Qid { get; set; }

        public virtual Lecturerassessment Assessment { get; set; }
        public virtual Question QidNavigation { get; set; }
    }
}
