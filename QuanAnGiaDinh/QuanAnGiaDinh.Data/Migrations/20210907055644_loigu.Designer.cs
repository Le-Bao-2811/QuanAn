﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanAnGiaDinh.Data;

namespace QuanAnGiaDinh.Data.Migrations
{
    [DbContext(typeof(QuanAnGiaDinhDbContext))]
    [Migration("20210907055644_loigu")]
    partial class loigu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.ChucVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChucVuNV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.DanhMucMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DanhMuc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DanhMucMenu");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.KVLamViec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("KVucLamViec")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KVLamViec");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.KhoQuan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int?>("IdTrangThai")
                        .HasColumnType("int");

                    b.Property<int?>("MahangId")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("Thucpham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaynhap")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdTrangThai");

                    b.HasIndex("MahangId");

                    b.ToTable("KhoQuan");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.MaHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int>("Kg")
                        .HasColumnType("int");

                    b.Property<string>("LoaiHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaHang");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int>("GiaTien")
                        .HasColumnType("int");

                    b.Property<int?>("IdDanhMuc")
                        .HasColumnType("int");

                    b.Property<int?>("IdTheLoai")
                        .HasColumnType("int");

                    b.Property<string>("ThucDon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDanhMuc");

                    b.HasIndex("IdTheLoai");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdChucVuNV")
                        .HasColumnType("int");

                    b.Property<int?>("IdKVucLamViec")
                        .HasColumnType("int");

                    b.Property<int>("Luong")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayVaoLam")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVuNV");

                    b.HasIndex("IdKVucLamViec");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varbinary(200)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varbinary(200)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.TheLoaiMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("TheLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TheLoaiMenu");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.TrangThaiKho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrangThaiKho");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.XuatKho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int?>("IdTrangThai")
                        .HasColumnType("int");

                    b.Property<int?>("MahangId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayXuatKho")
                        .HasColumnType("datetime2");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("Thucpham")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("XuatKho");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.KhoQuan", b =>
                {
                    b.HasOne("QuanAnGiaDinh.DTOs.TrangThaiKho", "trangThaiKho")
                        .WithMany("khoQuans")
                        .HasForeignKey("IdTrangThai");

                    b.HasOne("QuanAnGiaDinh.DTOs.MaHang", "maHang")
                        .WithMany("khoQuans")
                        .HasForeignKey("MahangId");

                    b.Navigation("maHang");

                    b.Navigation("trangThaiKho");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.Menu", b =>
                {
                    b.HasOne("QuanAnGiaDinh.DTOs.DanhMucMenu", "DanhMucMenu")
                        .WithMany("menus")
                        .HasForeignKey("IdDanhMuc");

                    b.HasOne("QuanAnGiaDinh.DTOs.TheLoaiMenu", "TheLoaiMenu")
                        .WithMany("menus")
                        .HasForeignKey("IdTheLoai");

                    b.Navigation("DanhMucMenu");

                    b.Navigation("TheLoaiMenu");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.NhanVien", b =>
                {
                    b.HasOne("QuanAnGiaDinh.DTOs.ChucVu", "ChucVu")
                        .WithMany("nhanViens")
                        .HasForeignKey("IdChucVuNV");

                    b.HasOne("QuanAnGiaDinh.DTOs.KVLamViec", "KVLamViec")
                        .WithMany("nhanViens")
                        .HasForeignKey("IdKVucLamViec");

                    b.Navigation("ChucVu");

                    b.Navigation("KVLamViec");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.ChucVu", b =>
                {
                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.DanhMucMenu", b =>
                {
                    b.Navigation("menus");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.KVLamViec", b =>
                {
                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.MaHang", b =>
                {
                    b.Navigation("khoQuans");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.TheLoaiMenu", b =>
                {
                    b.Navigation("menus");
                });

            modelBuilder.Entity("QuanAnGiaDinh.DTOs.TrangThaiKho", b =>
                {
                    b.Navigation("khoQuans");
                });
#pragma warning restore 612, 618
        }
    }
}
