using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAdmissionresidence
    {
        public int Residenceid { get; set; }
        public string Name { get; set; }
        public bool? Isinternational { get; set; }
    }
}
