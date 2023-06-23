using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Faculty1
    {
        public Faculty1()
        {
            Rooms = new HashSet<Room>();
        }

        public int FacultyId { get; set; }
        public string FacultyName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
