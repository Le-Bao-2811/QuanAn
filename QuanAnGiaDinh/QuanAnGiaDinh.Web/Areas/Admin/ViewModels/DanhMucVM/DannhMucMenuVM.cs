using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.DanhMucVM
{
	public class DannhMucMenuVM
	{
		public int Id { get; set; }
		[DisplayName("Danh mục")]
		public string DanhMuc { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
