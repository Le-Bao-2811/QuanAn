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
	[Table("DanhMucMenu")]
	public class DanhMucMenu
	{
		public DanhMucMenu()
		{
			menus = new HashSet<Menu>();
		}
		[Key]
		public int Id { get; set; }
		[DisplayName("Danh mục")]
		public string DanhMuc { get; set; }
		public int? DisplayOrder { get; set; }
		public ICollection< Menu> menus { get; set; }

	}
}
