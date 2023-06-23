using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Dayofweek
    {
        public Dayofweek()
        {
            Lecturerpreferences = new HashSet<Lecturerpreference>();
            Lecturetimetables = new HashSet<Lecturetimetable>();
        }

        public int Dayid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lecturerpreference> Lecturerpreferences { get; set; }
        public virtual ICollection<Lecturetimetable> Lecturetimetables { get; set; }
    }
}
