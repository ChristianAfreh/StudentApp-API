using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Idcardapirequestlog
    {
        public long Id { get; set; }
        public string ClientIp { get; set; }
        public DateTime RequestDate { get; set; }
        public string OperationName { get; set; }
        public string RequestDto { get; set; }
        public string RequestPath { get; set; }
        public int ApiuserId { get; set; }
        public string RequestMethod { get; set; }
    }
}
