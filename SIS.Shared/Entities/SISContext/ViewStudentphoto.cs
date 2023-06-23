using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewStudentphoto
    {
        public string Studentid { get; set; }
        public byte[] Photo { get; set; }
    }
}
