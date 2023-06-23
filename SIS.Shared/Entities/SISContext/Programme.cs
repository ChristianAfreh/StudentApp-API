using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programme
    {
        public Programme()
        {
            Lecturetimetables = new HashSet<Lecturetimetable>();
            Programmestreams = new HashSet<Programmestream>();
        }

        public int Programmeid { get; set; }
        public string Name { get; set; }
        public string Awardname { get; set; }
        public int Graduatetypeid { get; set; }
        public int? Certificatetypeid { get; set; }
        public string Shortcode { get; set; }
        public string Shortname { get; set; }
        public int? Academicgroupid { get; set; }
        public string Overview { get; set; }
        public string Coursecontent { get; set; }
        public string Requirement { get; set; }
        public string Career { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Longprogrammename { get; set; }
        public int Degreeid { get; set; }

        public virtual Academicgroup Academicgroup { get; set; }
        public virtual Certificatetype Certificatetype { get; set; }
        public virtual Graduatetype Graduatetype { get; set; }
        public virtual ICollection<Lecturetimetable> Lecturetimetables { get; set; }
        public virtual ICollection<Programmestream> Programmestreams { get; set; }
    }
}
