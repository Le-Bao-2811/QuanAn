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
		public DatHang(){
			chiTietDonDatHangs = new List<ChiTietDonDatHang>();
		}
		[Key]
		public int Id { get; set; }
		public string TenKH { get; set; }
		public string DiaChi { get; set; }
		public string SDT { get; set; }
		public int Sotien { get; set; }
		public DateTime ThoiGianDatHang { get; set; }
		public int? DisplayOrder { get; set; }
		public int? IdTaiKhoan { get; set; }
        public bool Duyet { get; set; }
        [ForeignKey(nameof(IdTaiKhoan))]
		public TaiKhoan taiKhoan { get; set; }
		public ICollection<ChiTietDonDatHang> chiTietDonDatHangs { get; set; }
	}
}
