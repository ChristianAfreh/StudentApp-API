using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentgraduationregister
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public Guid GraduationStreamId { get; set; }
        public byte[] PictureData { get; set; }
        public bool? IsPictureApproved { get; set; }
        public bool IsApprovalMessageSent { get; set; }
        public DateTime? MessageSentTime { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string VerifiedBy { get; set; }
    }
}
