using System;
namespace SIS.Shared.Entities.SISContext
{
    public class ProcStudentBillResult
    {
        public string STUDENTID { get; set; }
        public string INDEXNO { get; set; }
        public string STUDENTNAME { get; set; }
        public int PROGRAMMESTREAMID { get; set; }
        public string PROGRAMMESTREAM { get; set; }
        public string DEPARTMENT { get; set; }
        public int ACADYEAR { get; set; }
        public string ACADYEARSTRING { get; set; }
        public int SEM { get; set; }
        public int ACADLEVELID { get; set; }
        public Nullable<int> FEECATEGORYID { get; set; }
        public string FEECATEGORY { get; set; }
        public Nullable<int> FEETYPEID { get; set; }
        public string FEETYPE { get; set; }
        public string CURRENCYID { get; set; }
        public double AMOUNT { get; set; }
        //public double BALANCEBF { get; set; }
        //public double AMOUNTPAID { get; set; }
        //public double AMOUNTEXEMPTED { get; set; }
        //public double AMOUNTREFUNDED { get; set; }
        //public double BAL { get; set; }
    }
}
