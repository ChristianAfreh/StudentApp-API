using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Academicrecorduploadfile
    {
        public int Fileid { get; set; }
        public string Filename { get; set; }
        public double Filesize { get; set; }
        public byte[] Filedata { get; set; }
        public string Contenttype { get; set; }
        public string Coursecode { get; set; }
        public int? Lecturerid { get; set; }
        public DateTime Datetimeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Paramlist { get; set; }
    }
}
