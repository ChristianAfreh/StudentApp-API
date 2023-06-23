using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residencebookingexception
    {
        public int Id { get; set; }
        public int Acadyear { get; set; }
        public string Studentid { get; set; }
        public string Remark { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Username { get; set; }
    }
}
