using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class KhoQuanService :ServiceBase
	{
		public KhoQuanService():base()
		{
			this.NOT_DELETED_CONDITION = "ThucPham!=NULL";
			this.DELETE_STATEMENT = "ThucPham=NULL";
		}
	}
}
