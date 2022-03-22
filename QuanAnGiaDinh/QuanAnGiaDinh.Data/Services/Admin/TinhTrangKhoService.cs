using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class TinhTrangKhoService : ServiceBase
		{
			public TinhTrangKhoService() : base()
			{
				this.NOT_DELETED_CONDITION = "TrangThai!=\"Không tồn tại\"";
			}
		}
	
}
