using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class UserUnit
    {
        public int UserUnitId { get; set; }
        public string UserId { get; set; }
        public int UnitId { get; set; }

        public virtual TimetableUnit Unit { get; set; }
    }
}
