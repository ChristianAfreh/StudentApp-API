using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residencebookingtype
    {
        public Residencebookingtype()
        {
            Residencebookings = new HashSet<Residencebooking>();
        }

        public int Bookingtypeid { get; set; }
        public string Bookingtypename { get; set; }

        public virtual ICollection<Residencebooking> Residencebookings { get; set; }
    }
}
