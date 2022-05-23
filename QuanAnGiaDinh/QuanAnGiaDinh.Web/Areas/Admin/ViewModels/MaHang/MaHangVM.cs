using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.MaHang
{
	public class MaHangVM
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Loại Hàng")]
		public string LoaiHang { get; set; }
        public int TongSoLuong { get; set; }
        public int? DisplayOrder { get; set; }
	}
}
