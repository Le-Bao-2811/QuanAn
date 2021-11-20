using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.Menu
{
	public class MenuVM
	{
		public int Id { get; set; }
		[DisplayName("Thực đơn")]
		public string ThucDon { get; set; }
		public IFormFile Hinh { get; set; }

		[DisplayName("Danh Mục")]		
		public int? IdDanhMuc { get; set; }
		[DisplayName("Thể Loại")]
		public int? IdTheLoai { get; set; }
		public string duongdan { get; set; }
		[DisplayName("Giá Tiền")]
		public int GiaTien { get; set; }
		public int? DisplayOrder { get; set; }
		public DanhMucMenu danhMucMenu { get; set; }
		public TheLoaiMenu theLoaiMenu { get; set; }
		public class DanhMucMenu
		{
			public string DanhMuc { get; set; }
		}
		public class TheLoaiMenu
		{
			public string TheLoai { get; set; }
		}
			
	}
}
