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
	[Table("ChucVu")]
	public class ChucVu
	{
		public ChucVu()
		{
			nhanViens = new HashSet<NhanVien>();
		}
		[Key]
		public int Id { get; set; }
		[DisplayName("Chức vụ")]
		public string ChucVuNV { get; set; }
		public int? DisplayOrder { get; set; }
		public ICollection<NhanVien> nhanViens { get; set; }
	}
}
