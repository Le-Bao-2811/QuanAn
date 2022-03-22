using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
	public class KVLamViecService: ServiceBase
	{
		public KVLamViecService():base()
		{
			this.NOT_DELETED_CONDITION = "KVucLamViec!=\"Không tồn tại\"";
			this.DELETE_STATEMENT = "KVucLamViec=N\"Không tồn tại\"";
		}
	}
}
