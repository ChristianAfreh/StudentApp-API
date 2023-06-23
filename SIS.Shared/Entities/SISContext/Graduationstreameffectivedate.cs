using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationstreameffectivedate
    {
        public int Id { get; set; }
        public Guid Graduationstreamid { get; set; }
        public DateTime Effectivedate { get; set; }
    }
}
