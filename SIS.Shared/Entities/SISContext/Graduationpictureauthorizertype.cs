using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationpictureauthorizertype
    {
        public Graduationpictureauthorizertype()
        {
            Graduationpictureauthorizers = new HashSet<Graduationpictureauthorizer>();
        }

        public int Graduationpictureauthorizertypeid { get; set; }
        public string Graduationpictureauthorizertypename { get; set; }

        public virtual ICollection<Graduationpictureauthorizer> Graduationpictureauthorizers { get; set; }
    }
}
