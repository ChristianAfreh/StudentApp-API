using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class NursingstudentsTemppwdDel
    {
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string PhoneNumber { get; set; }
        public string SchoolEmail { get; set; }
        public bool Complete { get; set; }
    }
}
