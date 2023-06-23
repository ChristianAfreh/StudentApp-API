using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Departmenttype
    {
        public Departmenttype()
        {
            Graduationpictureauthorizers = new HashSet<Graduationpictureauthorizer>();
        }

        public int Departmenttypeid { get; set; }
        public string Departmenttypename { get; set; }

        public virtual ICollection<Graduationpictureauthorizer> Graduationpictureauthorizers { get; set; }
    }
}
