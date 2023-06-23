using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Idcardapidatastudent
    {
        public string ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Expires { get; set; }
        public string Type { get; set; }
        public string PostalAddress { get; set; }
    }
}
