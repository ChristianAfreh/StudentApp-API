using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
	public class TagDetailsDTO
	{
		public string STUDENTID { get; set; }
		public int PROGRAMMESTREAMID { get; set; }
		public int ACADYEAR { get; set; }
		public int SEM { get; set; }
		public int ACADLEVELID { get; set; }
		public int TAGID { get; set; }
		public string TAG { get; set; }
		public string REASON { get; set; }
	}
}
