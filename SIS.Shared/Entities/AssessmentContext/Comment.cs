using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Comment
    {
        public long Commentid { get; set; }
        public int Assessmentid { get; set; }
        public int Qid { get; set; }
        public string Comment1 { get; set; }

        public virtual Lecturerassessment Assessment { get; set; }
        public virtual Question QidNavigation { get; set; }
    }
}
