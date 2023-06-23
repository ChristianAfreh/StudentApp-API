using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Idcardapiuser
    {
        public long Id { get; set; }
        public string Apikey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Active { get; set; }
    }
}
