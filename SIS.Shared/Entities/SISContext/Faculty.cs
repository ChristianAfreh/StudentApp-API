using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Faculty
    {
        public Faculty()
        {
            Departments = new HashSet<Department>();
            Programmestreams = new HashSet<Programmestream>();
        }

        public int Facultyid { get; set; }
        public int? Collegeid { get; set; }
        public string Name { get; set; }
        public string Head { get; set; }
        public string Phone { get; set; }
        public string Phoneext { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Facultycode { get; set; }

        public virtual College College { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Programmestream> Programmestreams { get; set; }
    }
}
