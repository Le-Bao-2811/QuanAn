using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanAnGiaDinh.DTOs
{
	[Table("TrangThaiKho")]
	public class TrangThaiKho
	{
		public TrangThaiKho()
		{
			khoQuans = new HashSet<KhoQuan>();
		}
		[Key]
		public int Id { get; set; }
		[DisplayName("Trạng Thái")]
		public string TrangThai { get; set; }
		public int? DisplayOrder { get; set; }
		public ICollection<KhoQuan> khoQuans { get; set; }
	}
}
