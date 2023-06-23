using System;
namespace SIS.Shared.Entities.SISContext
{
    public class ProcStudentFeeTransactionResult
    {
        public string STUDENTID { get; set; }
        public int? PROGRAMMESTREAMID { get; set; }
        public int ACADYEAR { get; set; }
        public int SEM { get; set; }
        public string CURRENCYID { get; set; }
        public double? AMOUNTSOURCECURRENCY { get; set; }
        public double XRATE { get; set; }
        public double? EXTENDEDAMOUNT { get; set; }
        public string TRANSACTIONTYPE { get; set; }
        public DateTime TRANSDATE { get; set; }
        public DateTime TIMEINSERTED { get; set; }
        public string NARRATIVE { get; set; }
        public string INSERTEDBY { get; set; }
        public int? OFID { get; set; }
        public int ACADLEVELID { get; set; }
        public string NAME { get; set; }
        public string ACADYEARSTRING { get; set; }
        public string ACADLEVELSTRING { get; set; }
        public string SEMESTER { get; set; }
        public double? CUMULATIVETOTAL { get; set; }
        public long? GROUPID { get; set; }
    }
}
