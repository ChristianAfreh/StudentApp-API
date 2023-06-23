using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
	public class ResultsSlipOnlineDTO
	{
		public string STUDENTID { get; set; }
		public string INDEXNO { get; set; }
		public Nullable<int> PROGRAMMESTREAMID { get; set; }
		public string PROGRAMME { get; set; }
		public string NAME { get; set; }
		public string OPTIONS { get; set; }
		public string NATIONALITY { get; set; }
		public Nullable<double> SCR { get; set; }
		public Nullable<double> SCO { get; set; }
		public Nullable<double> SCC { get; set; }
		public Nullable<double> SWM { get; set; }
		public Nullable<double> SWA { get; set; }
		public Nullable<double> CCR { get; set; }
		public Nullable<double> CCO { get; set; }
		public Nullable<double> CCC { get; set; }
		public Nullable<double> CWM { get; set; }
		public Nullable<double> CWA { get; set; }
		public Nullable<int> NOOFTRAIL { get; set; }
		public string TRAIL { get; set; }
		public string TAG { get; set; }
		public string INSTITUTION { get; set; }
		public string DEPARTMENT { get; set; }
		public string REPHEADING { get; set; }
		public Nullable<int> YR { get; set; }
		public Nullable<System.DateTime> REPDATE { get; set; }
	}
}
