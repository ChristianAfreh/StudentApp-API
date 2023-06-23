using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAdmissionprogrammeoption
    {
        public int Optionid { get; set; }
        public int Programmestreamid { get; set; }
        public string Name { get; set; }
        public bool Isavailableonline { get; set; }
    }
}
