using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempResidentialBillImport
    {
        public string Studentid { get; set; }
        public string Roomno { get; set; }
        public string Residence { get; set; }
        public double Amount { get; set; }
        public int? Residenceid { get; set; }
    }
}
