using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residence
    {
        public Residence()
        {
            Alumnidetails = new HashSet<Alumnidetail>();
            Residencebookings = new HashSet<Residencebooking>();
            Students = new HashSet<Student>();
        }

        public int Residenceid { get; set; }
        public string Name { get; set; }
        public bool? Oncampus { get; set; }
        public string Gender { get; set; }
        public int? Altresidenceid { get; set; }
        public bool Istraditional { get; set; }

        public virtual ICollection<Alumnidetail> Alumnidetails { get; set; }
        public virtual ICollection<Residencebooking> Residencebookings { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
