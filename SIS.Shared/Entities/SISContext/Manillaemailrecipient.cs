using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Manillaemailrecipient
    {
        public int Id { get; set; }
        public string Emailaddress { get; set; }
        public bool Ismain { get; set; }
    }
}
