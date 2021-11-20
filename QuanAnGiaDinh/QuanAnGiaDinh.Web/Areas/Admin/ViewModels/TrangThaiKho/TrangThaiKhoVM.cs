using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Web.Areas.Admin.ViewModels.TrangThaiKho
{
	public class TrangThaiKhoVM
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Trạng Thái")]
		public string TrangThai { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
