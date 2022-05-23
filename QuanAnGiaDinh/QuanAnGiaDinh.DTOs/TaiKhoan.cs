using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
	[Table("TaiKhoan")]
	public class TaiKhoan
	{
		public TaiKhoan()
        {
			datHangs = new List<DatHang>();
			datBans = new List<DatBan>();
        }
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(200)]
		public string User { get; set; }
		[Required]
		[MaxLength(200)]
		public byte[] PasswordHash { get; set; }
		[Required]
		[MaxLength(200)]
		public byte[] PasswordSalt { get; set; }
		[Required]
		[MaxLength(200)]
		public string FullName { get; set; }
        public bool IsAdmin { get; set; }
		public int? IdRole { get; set; }
        public DateTime? CreateDate { get; set; }
		public ICollection<DatBan> datBans { get; set; }
		public ICollection<DatHang> datHangs { get; set; }
		public ICollection<NhanVien> nhanViens { get; set; }
		public ICollection<Menu> menus { get; set; }
		public ICollection<KhoQuan> khoQuans { get; set; }
	}
}
