using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Question
    {
        public Question()
        {
            Comments = new HashSet<Comment>();
            Responses = new HashSet<Response>();
        }

        public int Qid { get; set; }
        public int Setid { get; set; }
        public int Qno { get; set; }
        public string Question1 { get; set; }
        public bool? Iscomment { get; set; }
        public int? Categoryid { get; set; }

        public virtual Category Category { get; set; }
        public virtual Questionset Set { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
    }
}
