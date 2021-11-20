using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
	public class XuatKho
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Thực phẩm")]
		public string Thucpham { get; set; }
		[DisplayName("Trạng Thái")]
		public int? IdTrangThai { get; set; }
		[DisplayName("Số lượng")]
		public int Soluong { get; set; }
		[DisplayName("Mã hàng")]
		public int? MahangId { get; set; }
		[DisplayName("Ngày Xuất Kho")]
		public DateTime? NgayXuatKho { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
