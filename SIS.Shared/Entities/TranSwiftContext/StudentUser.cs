using System;
using System.Collections.Generic;

namespace SIS.Shared.Entities.TranSwiftContext
{
    public partial class StudentUser
    {
        public StudentUser()
        {
            Applicants = new HashSet<Applicant>();
        }

        public int StudentUserId { get; set; }
        public string StudentId { get; set; }
        public string StudentUsername { get; set; }
        public string StudentName { get; set; }
        public string StudentPersonalEmail { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
