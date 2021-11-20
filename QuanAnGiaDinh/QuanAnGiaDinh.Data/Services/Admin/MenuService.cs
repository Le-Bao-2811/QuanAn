using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class MenuService :ServiceBase
	{
		public MenuService():base()
		{
			this.NOT_DELETED_CONDITION = "ThucDon!=NULL";
			this.DELETE_STATEMENT = "ThucDon=NULL"; 
		}
	}
}
