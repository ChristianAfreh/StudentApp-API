using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentphotoupload
    {
        public string Studentid { get; set; }
        public byte[] Photo { get; set; }
        public DateTime? Whenuploaded { get; set; }
    }
}
