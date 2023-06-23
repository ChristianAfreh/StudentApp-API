using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Gradingsystemnonscoringcourse
    {
        public int Id { get; set; }
        public int Gradingid { get; set; }
        public string Coursecode { get; set; }

        public virtual Mastercourse CoursecodeNavigation { get; set; }
        public virtual Gradingsystem Grading { get; set; }
    }
}
