using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class UnitProgrammeStream
    {
        public int UnitProgrammeStreamId { get; set; }
        public int UnitId { get; set; }
        public int ProgrammeStreamId { get; set; }

        public virtual ProgrammeStream1 ProgrammeStream { get; set; }
        public virtual TimetableUnit Unit { get; set; }
    }
}
