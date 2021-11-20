
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.ChucVu
{
	public class ChucVuVM
	{
		public int Id { get; set; }
		[DisplayName("Chức vụ")]
		public string ChucVuNV { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
