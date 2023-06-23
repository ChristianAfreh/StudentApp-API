using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmeoption
    {
        public Programmeoption()
        {
            Coursesettings = new HashSet<Coursesetting>();
            Programmeoptioncoursecampuslecturers = new HashSet<Programmeoptioncoursecampuslecturer>();
            Programmeoptioncourselecturers = new HashSet<Programmeoptioncourselecturer>();
            Programmeoptioncourses = new HashSet<Programmeoptioncourse>();
            Programmeoptionusers = new HashSet<Programmeoptionuser>();
            Studentprogrammes = new HashSet<Studentprogramme>();
        }

        public int Optionid { get; set; }
        public int Programmestreamid { get; set; }
        public string Name { get; set; }
        public bool? Isavailableonline { get; set; }
        public string Optioncode { get; set; }

        public virtual Programmestream Programmestream { get; set; }
        public virtual ICollection<Coursesetting> Coursesettings { get; set; }
        public virtual ICollection<Programmeoptioncoursecampuslecturer> Programmeoptioncoursecampuslecturers { get; set; }
        public virtual ICollection<Programmeoptioncourselecturer> Programmeoptioncourselecturers { get; set; }
        public virtual ICollection<Programmeoptioncourse> Programmeoptioncourses { get; set; }
        public virtual ICollection<Programmeoptionuser> Programmeoptionusers { get; set; }
        public virtual ICollection<Studentprogramme> Studentprogrammes { get; set; }
    }
}
