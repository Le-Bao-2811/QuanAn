using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class NhanVienService:ServiceBase
	{
		public NhanVienService():base()
		{
			this.NOT_DELETED_CONDITION = "HoTen!=NULL";
			this.DELETE_STATEMENT = "HoTen=NULL";

		}
	}
}
