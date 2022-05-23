using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanAnGiaDinh.DTOs
{
	[Table("KhoQuan")]
	public class KhoQuan
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
        public int? idTaiKhoan { get; set; }
        [DisplayName("Ngày nhập")]
		public DateTime? ngaynhap { get; set; }
        public int? DisplayOrder { get; set; }

		[ForeignKey(nameof(MahangId))]
		public MaHang maHang { get; set; }

		[ForeignKey(nameof(IdTrangThai))]
		public TrangThaiKho trangThaiKho { get; set; }
		[ForeignKey(nameof(idTaiKhoan))]
		public TaiKhoan taiKhoan { get; set; }
	}
}
