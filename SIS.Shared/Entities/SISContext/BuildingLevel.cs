using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class BuildingLevel
    {
        public BuildingLevel()
        {
            Rooms = new HashSet<Room>();
        }

        public int BuildingFloorId { get; set; }
        public int BuildingId { get; set; }
        public int LevelId { get; set; }
        public string FloorName { get; set; }

        public virtual Building1 Building { get; set; }
        public virtual Level Level { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
