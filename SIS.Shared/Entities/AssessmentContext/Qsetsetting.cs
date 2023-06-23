using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Qsetsetting
    {
        public int Qsettingid { get; set; }
        public int Setid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Collegeid { get; set; }
        public int? Facultyid { get; set; }
        public int? Departmentid { get; set; }
        public int? Psid { get; set; }
        public string Coursecode { get; set; }
        public int? Yr { get; set; }

        public virtual Questionset Set { get; set; }
    }
}
