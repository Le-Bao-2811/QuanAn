using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanAnGiaDinh.DTOs
{
	[Table("MaHang")]
	public class MaHang
	{
		public MaHang()
		{
			khoQuans = new HashSet<KhoQuan>();
		}
		[Key]
		public int Id { get; set; }
		[DisplayName("Loại Hàng")]
		public string LoaiHang { get; set; }
		public int? DisplayOrder { get; set; }
		public DateTime DeleteDate { get; set; }
		public ICollection<KhoQuan> khoQuans { get; set; }
	}
}
