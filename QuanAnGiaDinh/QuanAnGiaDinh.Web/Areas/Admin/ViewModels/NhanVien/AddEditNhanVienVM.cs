using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.NhanVien
{
    public class AddEditNhanVienVM
    {
		public int Id { get; set; }
		[DisplayName("Họ Và Tên")]
		public string HoTen { get; set; }
		public string Diachi { get; set; }
		public string SDT { get; set; }
		[DisplayName("Chức vụ")]
		public int? IdChucVuNV { get; set; }
		[DisplayName("Khu vực làm việc")]
		public int? IdKVucLamViec { get; set; }
		[DisplayName("Ngày vào làm")]
		public DateTime? NgayVaoLam { get; set; }
		public int? DisplayOrder { get; set; }
		public int Luong { get; set; }
	}
}
