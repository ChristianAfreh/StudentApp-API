using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Category
    {
        public Category()
        {
            Questions = new HashSet<Question>();
        }

        public int Categoryid { get; set; }
        public int Setid { get; set; }
        public int Categoryorder { get; set; }
        public string Category1 { get; set; }
        public int Qfrom { get; set; }
        public int Qto { get; set; }
        public bool? Includeingrand { get; set; }
        public string Remarks { get; set; }

        public virtual Questionset Set { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
