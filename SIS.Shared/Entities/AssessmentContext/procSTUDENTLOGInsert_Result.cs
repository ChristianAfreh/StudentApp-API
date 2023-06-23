using System;
namespace SIS.Shared.Entities.AssessmentContext
{
    public class procSTUDENTLOGInsert_Result
    {
        public long STUDENTLOGID { get; set; }
        public int SETID { get; set; }
        public int ACADYEAR { get; set; }
        public int SEM { get; set; }
        public string STAFFID { get; set; }
        public string COURSECODE { get; set; }
        public string STUDENTID { get; set; }
        public DateTime WHENSUBMITTED { get; set; }
    }
}
