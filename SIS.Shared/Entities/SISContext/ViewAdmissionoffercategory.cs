using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAdmissionoffercategory
    {
        public int Admissionoffercategoryid { get; set; }
        public string Name { get; set; }
        public int? Feecategoryid { get; set; }
        public string Letterhead { get; set; }
        public string Offer { get; set; }
        public string Feefilename { get; set; }
    }
}
