using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Control
    {
        public Control()
        {
            Controlroles = new HashSet<Controlrole>();
        }

        public string Formname { get; set; }
        public string Controlname { get; set; }
        public string Description { get; set; }
        public string Navigation { get; set; }
        public string Controltype { get; set; }
        public string Ownercontrol { get; set; }
        public bool Isdefault { get; set; }

        public virtual ICollection<Controlrole> Controlroles { get; set; }
    }
}
