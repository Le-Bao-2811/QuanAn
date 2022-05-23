using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
    public class HoatDongService:ServiceBase
    {
		public HoatDongService() : base()
		{
			this.NOT_DELETED_CONDITION = "TenKH!=\"Không tồn tại\"";
			this.DELETE_STATEMENT = "TenKH=N\"Không tồn tại\"";
		}
	}
}

