using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.Entities.SISContext
{
    public class tblGetStudentProgrammeStreamData_Result
    {
        public string STUDENTID { get; set; }
        public int PROGRAMMESTREAMID { get; set; }
        public int GRADUATETYPEID { get; set; }
        public string INDEXNO { get; set; }
        public string SCHOOLRECOGNIZEDNAME { get; set; }
        public int ADMISSIONYEAR { get; set; }
    }
}
