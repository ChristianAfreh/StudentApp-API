using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.Entities.SISContext
{
    public class tblGetStudentBioData_Result
    {
        public string STUDENTID { get; set; }
        public string SURNAME { get; set; }
        public string OTHERNAME { get; set; }
        public string GENDER { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string SCHOOLEMAIL { get; set; }
        public string EMAIL { get; set; }
        public string PRIMARYMOBILE { get; set; }
        public string RESADDRESS { get; set; }
        public string POSTADDRESS { get; set; }
        public string COUNTRYID { get; set; }
    }
}
