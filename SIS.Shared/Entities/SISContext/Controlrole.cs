using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Controlrole
    {
        public string Formname { get; set; }
        public string Controlname { get; set; }
        public int Controlstate { get; set; }
        public string Roleid { get; set; }

        public virtual Control Control { get; set; }
        public virtual AspNetRole Role { get; set; }
    }
}
