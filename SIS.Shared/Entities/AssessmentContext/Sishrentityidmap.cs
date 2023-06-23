using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Sishrentityidmap
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public int Sisid { get; set; }
        public int Hrid { get; set; }
        public string Entityname { get; set; }
    }
}
