using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Courselecturer
    {
        public Courselecturer()
        {
            Programmeoptioncoursecampuslecturers = new HashSet<Programmeoptioncoursecampuslecturer>();
            Programmeoptioncourselecturers = new HashSet<Programmeoptioncourselecturer>();
            Programmeoptioncourses = new HashSet<Programmeoptioncourse>();
        }

        public int Lecturerid { get; set; }
        public string Coursecode { get; set; }
        public int Acadlevelid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public bool Isprimary { get; set; }

        public virtual Lecturer Lecturer { get; set; }
        public virtual ICollection<Programmeoptioncoursecampuslecturer> Programmeoptioncoursecampuslecturers { get; set; }
        public virtual ICollection<Programmeoptioncourselecturer> Programmeoptioncourselecturers { get; set; }
        public virtual ICollection<Programmeoptioncourse> Programmeoptioncourses { get; set; }
    }
}
