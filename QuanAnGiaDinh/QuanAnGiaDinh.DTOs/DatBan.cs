using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
	[Table("DatBan")]
	public class DatBan
	{
		[Key]
		public int Id { get; set; }
		public string TenKH { get; set; }
		public string STD { get; set; }
		public string KhuVuc { get; set; }
		public int? IdTaiKhoan { get; set; }
        public bool Duyet { get; set; }
        [ForeignKey(nameof(IdTaiKhoan))]
		public TaiKhoan taiKhoan { get; set; }
		public DateTime Ngay { get; set; }
		public DateTime Gio { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
