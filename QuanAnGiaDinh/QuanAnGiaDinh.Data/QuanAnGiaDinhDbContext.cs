using Microsoft.EntityFrameworkCore;
using QuanAnGiaDinh.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Data
{
	public class QuanAnGiaDinhDbContext : DbContext
	{
		public DbSet<KhoQuan> KhoQuan { get; set; }
		public DbSet<MaHang> MaHang { get; set; }
		public DbSet<TrangThaiKho> TrangThaiKho { get; set; }
		public DbSet<KVLamViec> KVLamViec { get; set; }
		public DbSet<NhanVien> NhanVien { get; set; }
		public DbSet<ChucVu> ChucVu { get; set; }
		public DbSet<Menu> Menu { get; set; }
		public DbSet<DanhMucMenu> DanhMucMenu { get; set; }
		public DbSet<TheLoaiMenu> TheLoaiMenu { get; set; }
		public DbSet<XuatKho> XuatKho { get; set; }
		public DbSet<TaiKhoan> taiKhoans { get; set; }
		public DbSet<DatBan> datBans { get; set; }
		public DbSet<DatHang> datHangs { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=LAPTOP-UHPOGM33;Initial Catalog=QuanAn;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		}
	}
}
