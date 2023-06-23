using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Department
    {
        public Department()
        {
            Alumnidetails = new HashSet<Alumnidetail>();
            Mastercourses = new HashSet<Mastercourse>();
            ProgrammestreamAffiliateddepartmentts = new HashSet<Programmestream>();
            ProgrammestreamDepartments = new HashSet<Programmestream>();
        }

        public int Departmentid { get; set; }
        public int? Facultyid { get; set; }
        public int? Collegeid { get; set; }
        public string Name { get; set; }
        public string Head { get; set; }
        public string Phone { get; set; }
        public string Phoneext { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public bool? Isactive { get; set; }

        public virtual College College { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Alumnidetail> Alumnidetails { get; set; }
        public virtual ICollection<Mastercourse> Mastercourses { get; set; }
        public virtual ICollection<Programmestream> ProgrammestreamAffiliateddepartmentts { get; set; }
        public virtual ICollection<Programmestream> ProgrammestreamDepartments { get; set; }
    }
}
