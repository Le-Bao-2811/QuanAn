using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
	[Table("DatHang")]
	public class DatHang
	{
		[Key]
		public int Id { get; set; }
		public string TenKH { get; set; }
		public string DiaChi { get; set; }
		public string MonAn { get; set; }
		public string SDT { get; set; }
		public int Sotien { get; set; }
		public DateTime ThoiGianDatHang { get; set; }
		public int? DisplayOrder { get; set; }
	}
}
