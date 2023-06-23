using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Questionset
    {
        public Questionset()
        {
            Categories = new HashSet<Category>();
            Lecturerassessments = new HashSet<Lecturerassessment>();
            Qsetsettings = new HashSet<Qsetsetting>();
            Questions = new HashSet<Question>();
            Studentlogs = new HashSet<Studentlog>();
        }

        public int Setid { get; set; }
        public string Setname { get; set; }
        public string Remarks { get; set; }
        public bool? Isdefault { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Lecturerassessment> Lecturerassessments { get; set; }
        public virtual ICollection<Qsetsetting> Qsetsettings { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Studentlog> Studentlogs { get; set; }
    }
}
