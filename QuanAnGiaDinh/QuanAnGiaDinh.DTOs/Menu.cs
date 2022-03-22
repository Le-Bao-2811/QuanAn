using Microsoft.AspNetCore.Http;
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
	[Table("Menu")]
	public class Menu
	{
		public Menu()
        {
			chiTietDonDatHangs = new List<ChiTietDonDatHang>();
        }
		[Key]
		public int Id { get; set; }
		[DisplayName("Thực đơn")]
		public string ThucDon { get; set; }
		[DisplayName("Danh Mục")]
		public int? IdDanhMuc { get; set; }
		[DisplayName("Thể Loại")]
		public int? IdTheLoai { get; set; }
        public int? idTaiKhoan { get; set; }
        [DisplayName("Giá Tiền")]
		public int GiaTien { get; set; }
		public string duongdan { get; set; }
        public int SLDaBan { get; set; }
        [NotMapped]
		public IFormFile Hinh { get; set; }
		public int? DisplayOrder { get; set; }
		[ForeignKey(nameof(IdDanhMuc))]
		public DanhMucMenu DanhMucMenu { get; set; }
		[ForeignKey(nameof(IdTheLoai))]
		public TheLoaiMenu TheLoaiMenu { get; set; }
		[ForeignKey(nameof(idTaiKhoan))]
		public TaiKhoan taiKhoan { get; set; }
		public ICollection<ChiTietDonDatHang> chiTietDonDatHangs { get; set; }

	}
}
