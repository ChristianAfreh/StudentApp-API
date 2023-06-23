using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Mobileappsetting
    {
        public int Id { get; set; }
        public int Minversion { get; set; }
        public bool Iscritical { get; set; }
        public bool Sendfcmtoken { get; set; }
        public string Helpurl { get; set; }
        public string Registrationinstructionurl { get; set; }
        public bool Usecustomupdatemessage { get; set; }
        public string Customupdatemessage { get; set; }
    }
}
