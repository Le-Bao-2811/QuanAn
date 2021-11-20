using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.KVLamViec
{
	public class KVucLamViecVM
	{
		public int Id { get; set; }
		[DisplayName("Khu vực làm việc")]
		public string KVucLamViec { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
