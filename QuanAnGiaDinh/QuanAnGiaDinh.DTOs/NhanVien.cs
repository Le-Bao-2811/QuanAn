using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
	public class NhanVien
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Họ Và Tên")]
		public string	HoTen { get; set; }
		[DisplayName("Chức vụ")]
		public int? IdChucVuNV { get; set; }
		[DisplayName("Khu vực làm việc")]
		public int? IdKVucLamViec { get; set; }
		[DisplayName("Ngày vào làm")]
		public DateTime? NgayVaoLam { get; set; }
		public int Luong { get; set; }
		public int? DisplayOrder { get; set; }
		[ForeignKey(nameof(IdKVucLamViec))]
		public KVLamViec KVLamViec { get; set; }
		[ForeignKey(nameof(IdChucVuNV))]
		public ChucVu ChucVu { get; set; }
	}
}
