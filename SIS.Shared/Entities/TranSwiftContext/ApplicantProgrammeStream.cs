using System;
using System.Collections.Generic;

namespace SIS.Shared.Entities.TranSwiftContext
{
    public partial class ApplicantProgrammeStream
    {
        public int ApplicantProgrammeStreamId { get; set; }
        public int ApplicantId { get; set; }
        public int ProgrammeStreamId { get; set; }
        public int GraduateTypeId { get; set; }
        public string StudentNumber { get; set; }
        public string SisprovidedStudentNumber { get; set; }
        public string IndexNo { get; set; }
        public string SchoolRecognizedName { get; set; }
        public short? AdmissionYear { get; set; }
        public short? GraduationYear { get; set; }
        public bool IsAutoVerified { get; set; }
        public bool IsManualVerified { get; set; }
        public bool IsVerificationComplete { get; set; }
        public bool? IsCorrectionRequired { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}
