using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.KhoQuan
{
    public class AddEiditKhoQuanVM
    {
		public int Id { get; set; }
		[DisplayName("Thực phẩm")]
		public string Thucpham { get; set; }
		[DisplayName("Trạng Thái")]
		public int? IdTrangThai { get; set; }
		[DisplayName("Số lượng")]
		public int Soluong { get; set; }
		[DisplayName("Mã hàng")]
		public int MahangId { get; set; }
		[DisplayName("Ngày nhập")]
		public DateTime? ngaynhap { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
