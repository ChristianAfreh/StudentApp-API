using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Examcentre
    {
        public Examcentre()
        {
            Academicrecords = new HashSet<Academicrecord>();
            Studentexamcentres = new HashSet<Studentexamcentre>();
        }

        public int Examcentreid { get; set; }
        public string Centrename { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Academicrecord> Academicrecords { get; set; }
        public virtual ICollection<Studentexamcentre> Studentexamcentres { get; set; }
    }
}
