using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class College
    {
        public College()
        {
            Alumnidetails = new HashSet<Alumnidetail>();
            Classrooms = new HashSet<Classroom>();
            Departments = new HashSet<Department>();
            Faculties = new HashSet<Faculty>();
            Programmestreams = new HashSet<Programmestream>();
        }

        public int Collegeid { get; set; }
        public string Name { get; set; }
        public string Head { get; set; }
        public string Phone { get; set; }
        public string Phoneext { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Collegecode { get; set; }
        public string Registrationemail { get; set; }

        public virtual ICollection<Alumnidetail> Alumnidetails { get; set; }
        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<Programmestream> Programmestreams { get; set; }
    }
}
