using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Staffphoto
    {
        public string Staffid { get; set; }
        public byte[] Photo { get; set; }
    }
}
