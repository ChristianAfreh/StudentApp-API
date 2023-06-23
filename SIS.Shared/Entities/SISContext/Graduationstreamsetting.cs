using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationstreamsetting
    {
        public Guid Graduationstreamid { get; set; }
        public int Graduatetypeid { get; set; }
        public int Isclosed { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}
