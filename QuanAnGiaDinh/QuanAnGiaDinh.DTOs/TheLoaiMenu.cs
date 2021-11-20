using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
	public class TheLoaiMenu
	{
		public TheLoaiMenu()
		{
			menus = new HashSet<Menu>();
		}
		[Key]
		public int Id { get; set; }
		[DisplayName("Thể Loại")]
		public string TheLoai { get; set; }
		public int? DisplayOrder { get; set; }
		public ICollection<Menu> menus { get; set; }
	}
}
