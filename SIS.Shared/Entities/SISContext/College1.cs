using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class College1
    {
        public College1()
        {
            Rooms = new HashSet<Room>();
        }

        public int CollegeId { get; set; }
        public string CollegeName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
