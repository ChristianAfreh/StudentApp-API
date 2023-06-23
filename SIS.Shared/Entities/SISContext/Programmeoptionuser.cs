using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmeoptionuser
    {
        public int Optionid { get; set; }
        public int Programmestreamid { get; set; }
        public string Userid { get; set; }

        public virtual Programmeoption Programmeoption { get; set; }
    }
}
