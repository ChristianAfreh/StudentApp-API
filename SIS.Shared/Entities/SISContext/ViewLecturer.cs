using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewLecturer
    {
        public int Lecturerid { get; set; }
        public string LecturerTitle { get; set; }
        public string LecturerName { get; set; }
        public int? Staffid { get; set; }
        public string Staffid2 { get; set; }
    }
}
