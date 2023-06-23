using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentgraduationregisterlog
    {
        public int LogId { get; set; }
        public int Id { get; set; }
        public string StudentId { get; set; }
        public byte[] OldPictureData { get; set; }
        public byte[] NewPictureData { get; set; }
        public bool? OldApprovalValue { get; set; }
        public bool? NewApprovalValue { get; set; }
        public string ActionTaken { get; set; }
        public DateTime ActionTime { get; set; }
        public string ClientNetAddress { get; set; }
    }
}
