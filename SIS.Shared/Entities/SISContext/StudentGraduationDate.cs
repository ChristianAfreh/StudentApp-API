using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class StudentGraduationDate
    {
        public Guid Graduationstreamid { get; set; }
        public string College { get; set; }
        public DateTime Graduationdate { get; set; }

        public virtual Graduationstream Graduationstream { get; set; }
    }
}
