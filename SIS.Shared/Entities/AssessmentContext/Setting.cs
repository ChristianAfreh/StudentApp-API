using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Setting
    {
        public int Id { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public bool? Published { get; set; }
        public bool Isdefault { get; set; }
    }
}
