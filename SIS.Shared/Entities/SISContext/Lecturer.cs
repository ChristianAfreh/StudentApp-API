using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            Courselecturers = new HashSet<Courselecturer>();
            Programmecourses = new HashSet<Programmecourse>();
        }

        public int Lecturerid { get; set; }
        public int Staffid { get; set; }
        public string Fullname { get; set; }

        public virtual ICollection<Courselecturer> Courselecturers { get; set; }
        public virtual ICollection<Programmecourse> Programmecourses { get; set; }
    }
}
