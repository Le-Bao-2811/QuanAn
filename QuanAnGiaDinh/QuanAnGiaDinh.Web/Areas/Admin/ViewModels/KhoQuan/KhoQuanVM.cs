using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using QuanAnGiaDinh.DTOs;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.KhoQuan
{
	public class KhoQuanVM
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
		public TrangThaiKho trangThaiKho { get; set; }
		public MaHang maHang { get; set; }

		public class TrangThaiKho
		{
			public string TrangThai { get; set; }
		}

		public class MaHang
		{
			public string LoaiHang { get; set; }
		}
	}
}
