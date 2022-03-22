USE [QuanAn]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChucVuNV] [nvarchar](max) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucMenu]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DanhMuc] [nvarchar](max) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_DanhMucMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatBan]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatBan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](max) NULL,
	[KhuVuc] [nvarchar](max) NULL,
	[Ngay] [datetime2](7) NOT NULL,
	[Gio] [datetime2](7) NOT NULL,
	[DisplayOrder] [int] NULL,
	[STD] [nvarchar](max) NULL,
 CONSTRAINT [PK_DatBan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[Sotien] [int] NOT NULL,
	[ThoiGianDatHang] [datetime2](7) NOT NULL,
	[DisplayOrder] [int] NULL,
	[MonAn] [nvarchar](max) NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoQuan]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoQuan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Thucpham] [nvarchar](max) NULL,
	[IdTrangThai] [int] NULL,
	[Soluong] [int] NOT NULL,
	[MahangId] [int] NULL,
	[ngaynhap] [datetime2](7) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_KhoQuan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KVLamViec]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KVLamViec](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KVucLamViec] [nvarchar](max) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_KVLamViec] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaHang]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiHang] [nvarchar](max) NULL,
	[Kg] [int] NOT NULL,
	[DisplayOrder] [int] NULL,
	[DeleteDate] [datetime2](7) NOT NULL DEFAULT ('0001-01-01T00:00:00.0000000'),
 CONSTRAINT [PK_MaHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ThucDon] [nvarchar](max) NULL,
	[IdDanhMuc] [int] NULL,
	[IdTheLoai] [int] NULL,
	[GiaTien] [int] NOT NULL,
	[DisplayOrder] [int] NULL,
	[duongdan] [nvarchar](max) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](max) NULL,
	[IdChucVuNV] [int] NULL,
	[IdKVucLamViec] [int] NULL,
	[NgayVaoLam] [datetime2](7) NULL,
	[DisplayOrder] [int] NULL,
	[Luong] [int] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User] [nvarchar](200) NOT NULL,
	[PasswordHash] [varbinary](200) NOT NULL,
	[PasswordSalt] [varbinary](200) NOT NULL,
	[FullName] [nvarchar](200) NOT NULL,
	[CreateDate] [datetime2](7) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoaiMenu]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoaiMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TheLoai] [nvarchar](max) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_TheLoaiMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThaiKho]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiKho](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TrangThai] [nvarchar](max) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_TrangThaiKho] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XuatKho]    Script Date: 12/30/2021 2:21:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XuatKho](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Thucpham] [nvarchar](max) NULL,
	[IdTrangThai] [int] NULL,
	[Soluong] [int] NOT NULL,
	[MahangId] [int] NULL,
	[NgayXuatKho] [datetime2](7) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_XuatKho] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[KhoQuan]  WITH CHECK ADD  CONSTRAINT [FK_KhoQuan_MaHang_MahangId] FOREIGN KEY([MahangId])
REFERENCES [dbo].[MaHang] ([Id])
GO
ALTER TABLE [dbo].[KhoQuan] CHECK CONSTRAINT [FK_KhoQuan_MaHang_MahangId]
GO
ALTER TABLE [dbo].[KhoQuan]  WITH CHECK ADD  CONSTRAINT [FK_KhoQuan_TrangThaiKho_IdTrangThai] FOREIGN KEY([IdTrangThai])
REFERENCES [dbo].[TrangThaiKho] ([Id])
GO
ALTER TABLE [dbo].[KhoQuan] CHECK CONSTRAINT [FK_KhoQuan_TrangThaiKho_IdTrangThai]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_DanhMucMenu_IdDanhMuc] FOREIGN KEY([IdDanhMuc])
REFERENCES [dbo].[DanhMucMenu] ([Id])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_DanhMucMenu_IdDanhMuc]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_TheLoaiMenu_IdTheLoai] FOREIGN KEY([IdTheLoai])
REFERENCES [dbo].[TheLoaiMenu] ([Id])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_TheLoaiMenu_IdTheLoai]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu_IdChucVuNV] FOREIGN KEY([IdChucVuNV])
REFERENCES [dbo].[ChucVu] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu_IdChucVuNV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_KVLamViec_IdKVucLamViec] FOREIGN KEY([IdKVucLamViec])
REFERENCES [dbo].[KVLamViec] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_KVLamViec_IdKVucLamViec]
GO
