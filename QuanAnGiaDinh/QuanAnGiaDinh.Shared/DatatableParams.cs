using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Shared
{
	public class DatatableParams
	{
		public int draw { get; set; }
		public int start { get; set; }
		public int length { get; set; }
		public Dictionary<string,string> search { get; set; }

		public string searchValue
		{
			get { return search["value"]; }
			set { searchValue = value; }
		}
		public int page
		{
			get { return start / length + 1; }
			set { page = value; }
		}
	}
}
