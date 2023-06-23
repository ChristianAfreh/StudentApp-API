using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class UnitBuilding
    {
        public int UnitBuildingId { get; set; }
        public int UnitId { get; set; }
        public int BuildingId { get; set; }

        public virtual Building1 Building { get; set; }
        public virtual TimetableUnit Unit { get; set; }
    }
}
