using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanAnGiaDinh.DTOs
{
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
		[DisplayName("Tổng số lượng")]
		public int Kg { get; set; }
		public int? DisplayOrder { get; set; }
		public DateTime DeleteDate { get; set; }
		public ICollection<KhoQuan> khoQuans { get; set; }
	}
}
