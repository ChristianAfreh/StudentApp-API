using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Resittemplate
    {
        public Resittemplate()
        {
            Programmestreams = new HashSet<Programmestream>();
            Resitfeecategorymappings = new HashSet<Resitfeecategorymapping>();
        }

        public int Resittemplateid { get; set; }
        public string Resittemplatename { get; set; }

        public virtual ICollection<Programmestream> Programmestreams { get; set; }
        public virtual ICollection<Resitfeecategorymapping> Resitfeecategorymappings { get; set; }
    }
}
