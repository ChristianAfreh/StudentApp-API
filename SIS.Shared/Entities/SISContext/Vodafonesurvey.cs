using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Vodafonesurvey
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public int Choice { get; set; }
        public string Comment { get; set; }
    }
}
