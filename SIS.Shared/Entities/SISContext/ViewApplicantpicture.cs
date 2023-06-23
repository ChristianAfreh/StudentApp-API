using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewApplicantpicture
    {
        public string Applicantid { get; set; }
        public byte[] Picture { get; set; }
    }
}
