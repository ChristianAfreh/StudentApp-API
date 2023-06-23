using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            AspNetUserRoles = new HashSet<AspNetUserRole>();
            Controlroles = new HashSet<Controlrole>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<Controlrole> Controlroles { get; set; }
    }
}
