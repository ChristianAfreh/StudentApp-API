using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Building1
    {
        public Building1()
        {
            BuildingLevels = new HashSet<BuildingLevel>();
            UnitBuildings = new HashSet<UnitBuilding>();
        }

        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public string BuildingCode { get; set; }
        public string BuildingNotes { get; set; }
        public string BuildingLocation { get; set; }
        public double? BuildingLatitude { get; set; }
        public double? BuildingLongitude { get; set; }

        public virtual ICollection<BuildingLevel> BuildingLevels { get; set; }
        public virtual ICollection<UnitBuilding> UnitBuildings { get; set; }
    }
}
