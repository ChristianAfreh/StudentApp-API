using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Ttxp
    {
        public int Xpid { get; set; }
        public int? Classroomid { get; set; }
        public int? Periodid { get; set; }
        public int? Lecturecapacity { get; set; }
    }
}
