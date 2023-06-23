using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TimetableUnit
    {
        public TimetableUnit()
        {
            UnitBuildings = new HashSet<UnitBuilding>();
            UserUnits = new HashSet<UserUnit>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public virtual ICollection<UnitBuilding> UnitBuildings { get; set; }
        public virtual ICollection<UserUnit> UserUnits { get; set; }
    }
}
