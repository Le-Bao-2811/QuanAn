using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.TheLoai
{
	public class TheLoaiMenuVM
	{
		public int Id { get; set; }
		[DisplayName("Thể Loại")]
		public string TheLoai { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
