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
		public DateTime? CreateDate { get; set; }
	}
}
