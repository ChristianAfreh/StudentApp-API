using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Level
    {
        public Level()
        {
            BuildingLevels = new HashSet<BuildingLevel>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public int LevelNumber { get; set; }

        public virtual ICollection<BuildingLevel> BuildingLevels { get; set; }
    }
}
