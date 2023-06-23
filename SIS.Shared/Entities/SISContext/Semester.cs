using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Semester
    {
        public Semester()
        {
            Coursesettings = new HashSet<Coursesetting>();
            Feeschedules = new HashSet<Feeschedule>();
            Programmecourses = new HashSet<Programmecourse>();
            Programmeoptioncoursecampuslecturers = new HashSet<Programmeoptioncoursecampuslecturer>();
            Programmeoptioncourselecturers = new HashSet<Programmeoptioncourselecturer>();
            Programmeoptioncourses = new HashSet<Programmeoptioncourse>();
            Programmesemesters = new HashSet<Programmesemester>();
            StudentbiometricInclusions = new HashSet<StudentbiometricInclusion>();
            Studentbiometricverifications = new HashSet<Studentbiometricverification>();
            Studentfeeexemptions = new HashSet<Studentfeeexemption>();
            Studentoncampusverifications = new HashSet<Studentoncampusverification>();
            Studentpayments = new HashSet<Studentpayment>();
            Studentrefunds = new HashSet<Studentrefund>();
            Studentsemesters = new HashSet<Studentsemester>();
        }

        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public bool? Islocked { get; set; }

        public virtual Semestertype SemNavigation { get; set; }
        public virtual ICollection<Coursesetting> Coursesettings { get; set; }
        public virtual ICollection<Feeschedule> Feeschedules { get; set; }
        public virtual ICollection<Programmecourse> Programmecourses { get; set; }
        public virtual ICollection<Programmeoptioncoursecampuslecturer> Programmeoptioncoursecampuslecturers { get; set; }
        public virtual ICollection<Programmeoptioncourselecturer> Programmeoptioncourselecturers { get; set; }
        public virtual ICollection<Programmeoptioncourse> Programmeoptioncourses { get; set; }
        public virtual ICollection<Programmesemester> Programmesemesters { get; set; }
        public virtual ICollection<StudentbiometricInclusion> StudentbiometricInclusions { get; set; }
        public virtual ICollection<Studentbiometricverification> Studentbiometricverifications { get; set; }
        public virtual ICollection<Studentfeeexemption> Studentfeeexemptions { get; set; }
        public virtual ICollection<Studentoncampusverification> Studentoncampusverifications { get; set; }
        public virtual ICollection<Studentpayment> Studentpayments { get; set; }
        public virtual ICollection<Studentrefund> Studentrefunds { get; set; }
        public virtual ICollection<Studentsemester> Studentsemesters { get; set; }
    }
}
