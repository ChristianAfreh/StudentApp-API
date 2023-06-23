using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Institution
    {
        public int Instid { get; set; }
        public int? Institutiontypeid { get; set; }
        public string Name { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }
        public string Add5 { get; set; }
        public byte[] Logo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public bool? Islevelbased { get; set; }
        public string Shortcode { get; set; }

        public virtual Institutiontype Institutiontype { get; set; }
    }
}
