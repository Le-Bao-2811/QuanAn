﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class DanhMucMenuService: ServiceBase
	{
		public DanhMucMenuService():base()
		{
			this.NOT_DELETED_CONDITION = " DanhMuc!=NULL";
			this.DELETE_STATEMENT = " DanhMuc=NULL";
		}
		
	}
}
