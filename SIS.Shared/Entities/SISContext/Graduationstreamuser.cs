using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationstreamuser
    {
        public Guid Graduationstreamid { get; set; }
        public int Graduatypeid { get; set; }
        public string Userid { get; set; }

        public virtual Graduationstream Graduationstream { get; set; }
        public virtual Graduatetype Graduatype { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
