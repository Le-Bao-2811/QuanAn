using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class TheLoaiMenuService: ServiceBase
	{
		public TheLoaiMenuService():base()
		{
			this.NOT_DELETED_CONDITION = "TheLoai!=NULL";
			this.DELETE_STATEMENT = "TheLoai=NULL";
		}
	}
}
