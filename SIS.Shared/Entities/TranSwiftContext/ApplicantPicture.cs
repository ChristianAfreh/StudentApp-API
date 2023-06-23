using System;
using System.Collections.Generic;

namespace SIS.Shared.Entities.TranSwiftContext
{
    public partial class ApplicantPicture
    {
        public int ApplicantPictureId { get; set; }
        public int ApplicantId { get; set; }
        public byte[] ApplicantPicture1 { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}
