using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class ChucVuService: ServiceBase
	{
	 public	ChucVuService(): base()
		{
			this.NOT_DELETED_CONDITION = "ChucVuNV!=\"Không tồn tại\"";
			this.DELETE_STATEMENT = "ChucVuNV=N\"Không tồn tại\"";
		}
	}
}
