using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Tag
    {
        public Tag()
        {
            Taggedstudents = new HashSet<Taggedstudent>();
        }

        public int Tagid { get; set; }
        public string Name { get; set; }
        public int? Sortno { get; set; }
        public string Singulardef { get; set; }
        public string Pluraldef { get; set; }
        public string Acadhead { get; set; }
        public bool Show { get; set; }
        public bool Promote { get; set; }

        public virtual ICollection<Taggedstudent> Taggedstudents { get; set; }
    }
}
