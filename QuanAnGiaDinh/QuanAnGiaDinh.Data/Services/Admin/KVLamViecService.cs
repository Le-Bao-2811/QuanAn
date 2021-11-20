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
			this.NOT_DELETED_CONDITION = "KVucLamViec!=NULL";
			this.DELETE_STATEMENT = "KVucLamViec=NULL";
		}
	}
}
