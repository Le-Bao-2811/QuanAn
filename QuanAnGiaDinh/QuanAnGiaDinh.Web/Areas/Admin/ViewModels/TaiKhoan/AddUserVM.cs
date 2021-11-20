using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.TaiKhoan
{
	public class AddUserVM
	{
		[MinLength(3, ErrorMessage = "Tên đăng nhập quá ngắn")]
		[MaxLength(20, ErrorMessage = "Tên đăng nhập quá dài")]
		[Required(ErrorMessage = "Dữ liệu này là bắt buộc")]
		public string UserName { get; set; }
		[DataType(DataType.Password)]
		[MinLength(4)]
		[Required(ErrorMessage = "Dữ liệu này là bắt buộc")]
		public string Password { get; set; }
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Mật khẩu không khớp")]
		public string ComfirmPassword { get; set; }
		[Required(ErrorMessage = "Dữ liệu này là bắt buộc")]
		public string FullName { get; set; }
	}
}
