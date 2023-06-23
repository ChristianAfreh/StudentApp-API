using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewApplicantadmittedqueue
    {
        public int Id { get; set; }
        public int Applicantadmittedid { get; set; }
        public string Studentid { get; set; }
        public int Applicantid { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}
