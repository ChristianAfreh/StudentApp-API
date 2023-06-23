using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Gradingsystem
    {
        public Gradingsystem()
        {
            ClassparameterBks = new HashSet<ClassparameterBk>();
            Classparameters = new HashSet<Classparameter>();
            Gradingsystemclasses = new HashSet<Gradingsystemclass>();
            Gradingsystemnonscoringcourses = new HashSet<Gradingsystemnonscoringcourse>();
            Gradingsystemscoringexceptions = new HashSet<Gradingsystemscoringexception>();
            Gradingsystemscorings = new HashSet<Gradingsystemscoring>();
            Programmestreams = new HashSet<Programmestream>();
        }

        public int Gradingid { get; set; }
        public string Name { get; set; }
        public int? Sortno { get; set; }
        public int Gradingsystemtypeid { get; set; }

        public virtual Gradingsystemtype Gradingsystemtype { get; set; }
        public virtual ICollection<ClassparameterBk> ClassparameterBks { get; set; }
        public virtual ICollection<Classparameter> Classparameters { get; set; }
        public virtual ICollection<Gradingsystemclass> Gradingsystemclasses { get; set; }
        public virtual ICollection<Gradingsystemnonscoringcourse> Gradingsystemnonscoringcourses { get; set; }
        public virtual ICollection<Gradingsystemscoringexception> Gradingsystemscoringexceptions { get; set; }
        public virtual ICollection<Gradingsystemscoring> Gradingsystemscorings { get; set; }
        public virtual ICollection<Programmestream> Programmestreams { get; set; }
    }
}
