using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class FloorType
    {
        public FloorType()
        {
            Rooms = new HashSet<Room>();
        }

        public int FloorTypeId { get; set; }
        public string FloorTypeName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
