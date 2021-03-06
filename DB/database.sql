USE [QuanAN]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/9/2022 1:55:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 6/9/2022 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[IdDatHang] [int] NOT NULL,
	[IdMenu] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[IdDatHang] ASC,
	[IdMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 6/9/2022 1:55:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucMenu]    Script Date: 6/9/2022 1:55:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatBan]    Script Date: 6/9/2022 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatBan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](max) NULL,
	[STD] [nvarchar](max) NULL,
	[KhuVuc] [nvarchar](max) NULL,
	[IdTaiKhoan] [int] NULL,
	[Ngay] [datetime2](7) NOT NULL,
	[Gio] [datetime2](7) NOT NULL,
	[DisplayOrder] [int] NULL,
	[Duyet] [bit] NOT NULL,
 CONSTRAINT [PK_DatBan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 6/9/2022 1:55:16 PM ******/
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
	[IdTaiKhoan] [int] NULL,
	[Duyet] [bit] NOT NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoQuan]    Script Date: 6/9/2022 1:55:16 PM ******/
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
	[idTaiKhoan] [int] NULL,
	[ngaynhap] [datetime2](7) NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_KhoQuan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KVLamViec]    Script Date: 6/9/2022 1:55:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaHang]    Script Date: 6/9/2022 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiHang] [nvarchar](max) NULL,
	[TongSoLuong] [int] NOT NULL,
	[DisplayOrder] [int] NULL,
	[DeleteDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MaHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 6/9/2022 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ThucDon] [nvarchar](max) NULL,
	[Mota] [nvarchar](max) NULL,
	[IdDanhMuc] [int] NULL,
	[IdTheLoai] [int] NULL,
	[idTaiKhoan] [int] NULL,
	[GiaTien] [int] NOT NULL,
	[duongdan] [nvarchar](max) NULL,
	[SLDaBan] [int] NOT NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/9/2022 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](max) NULL,
	[Diachi] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[IdChucVuNV] [int] NULL,
	[IdKVucLamViec] [int] NULL,
	[NgayVaoLam] [datetime2](7) NULL,
	[Luong] [int] NOT NULL,
	[duongdanimg] [nvarchar](max) NULL,
	[idTaiKhoan] [int] NULL,
	[DisplayOrder] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/9/2022 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User] [nvarchar](200) NOT NULL,
	[PasswordHash] [varbinary](200) NOT NULL,
	[PasswordSalt] [varbinary](200) NOT NULL,
	[FullName] [nvarchar](200) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[IdRole] [int] NULL,
	[CreateDate] [datetime2](7) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoaiMenu]    Script Date: 6/9/2022 1:55:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiKho]    Script Date: 6/9/2022 1:55:16 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428165333_xoa-role', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220520060727_suaid', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220520061710_suaid1', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220520125219_duyer', N'5.0.7')
GO
INSERT [dbo].[ChiTietDonHang] ([IdDatHang], [IdMenu], [SoLuong], [ThanhTien]) VALUES (2, 1, 4, 320000)
INSERT [dbo].[ChiTietDonHang] ([IdDatHang], [IdMenu], [SoLuong], [ThanhTien]) VALUES (2, 2, 3, 180000)
INSERT [dbo].[ChiTietDonHang] ([IdDatHang], [IdMenu], [SoLuong], [ThanhTien]) VALUES (3, 1, 3, 240000)
INSERT [dbo].[ChiTietDonHang] ([IdDatHang], [IdMenu], [SoLuong], [ThanhTien]) VALUES (3, 2, 3, 180000)
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([Id], [ChucVuNV], [DisplayOrder]) VALUES (1, N'Quản lý', NULL)
INSERT [dbo].[ChucVu] ([Id], [ChucVuNV], [DisplayOrder]) VALUES (2, N'Nhân  viên phục vụ', NULL)
INSERT [dbo].[ChucVu] ([Id], [ChucVuNV], [DisplayOrder]) VALUES (3, N'Nhân viên kế toán', NULL)
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMucMenu] ON 

INSERT [dbo].[DanhMucMenu] ([Id], [DanhMuc], [DisplayOrder]) VALUES (1, N'Món chiên', NULL)
INSERT [dbo].[DanhMucMenu] ([Id], [DanhMuc], [DisplayOrder]) VALUES (2, N'Món xào', NULL)
INSERT [dbo].[DanhMucMenu] ([Id], [DanhMuc], [DisplayOrder]) VALUES (3, N'Thức ống có ga', NULL)
INSERT [dbo].[DanhMucMenu] ([Id], [DanhMuc], [DisplayOrder]) VALUES (4, N'Thức uống có cồn', NULL)
SET IDENTITY_INSERT [dbo].[DanhMucMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[DatBan] ON 

INSERT [dbo].[DatBan] ([Id], [TenKH], [STD], [KhuVuc], [IdTaiKhoan], [Ngay], [Gio], [DisplayOrder], [Duyet]) VALUES (1, N'Lê Trần Hoài Bảo', N'1223971231', N'Phòng tiệc', NULL, CAST(N'2022-05-23T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-21T22:25:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[DatBan] OFF
GO
SET IDENTITY_INSERT [dbo].[DatHang] ON 

INSERT [dbo].[DatHang] ([Id], [TenKH], [DiaChi], [SDT], [Sotien], [ThoiGianDatHang], [DisplayOrder], [IdTaiKhoan], [Duyet]) VALUES (2, N'Hoài Bảo', N'0522995259', N'Sóc Trăng', 500000, CAST(N'2022-05-20T19:56:49.5204078' AS DateTime2), NULL, 1, 1)
INSERT [dbo].[DatHang] ([Id], [TenKH], [DiaChi], [SDT], [Sotien], [ThoiGianDatHang], [DisplayOrder], [IdTaiKhoan], [Duyet]) VALUES (3, N'Hoài Bảo', N'214', N'1324', 420000, CAST(N'2022-05-26T11:26:56.5134394' AS DateTime2), NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[DatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[KhoQuan] ON 

INSERT [dbo].[KhoQuan] ([Id], [Thucpham], [IdTrangThai], [Soluong], [MahangId], [idTaiKhoan], [ngaynhap], [DisplayOrder]) VALUES (1, N'rau muốn', 1, 154, 2, NULL, CAST(N'2022-05-20T13:26:46.1776775' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[KhoQuan] OFF
GO
SET IDENTITY_INSERT [dbo].[KVLamViec] ON 

INSERT [dbo].[KVLamViec] ([Id], [KVucLamViec], [DisplayOrder]) VALUES (1, N'Sảnh A', NULL)
INSERT [dbo].[KVLamViec] ([Id], [KVucLamViec], [DisplayOrder]) VALUES (2, N'Sân Thượng', NULL)
SET IDENTITY_INSERT [dbo].[KVLamViec] OFF
GO
SET IDENTITY_INSERT [dbo].[MaHang] ON 

INSERT [dbo].[MaHang] ([Id], [LoaiHang], [TongSoLuong], [DisplayOrder], [DeleteDate]) VALUES (2, N'Rau củ quả', 154, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[MaHang] ([Id], [LoaiHang], [TongSoLuong], [DisplayOrder], [DeleteDate]) VALUES (3, N'Thịt sống', 0, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[MaHang] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Id], [ThucDon], [Mota], [IdDanhMuc], [IdTheLoai], [idTaiKhoan], [GiaTien], [duongdan], [SLDaBan], [DisplayOrder]) VALUES (1, N'Thịt heo xào rau củ', NULL, 2, 1, NULL, 80000, N'thitheoxao10-05-2022-13-01-58-008.jpg', 0, NULL)
INSERT [dbo].[Menu] ([Id], [ThucDon], [Mota], [IdDanhMuc], [IdTheLoai], [idTaiKhoan], [GiaTien], [duongdan], [SLDaBan], [DisplayOrder]) VALUES (2, N'Lưỡi heo xào ', NULL, 2, 1, NULL, 60000, N'luoiheoxao120-05-2022-13-02-37-104.jpg', 0, NULL)
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([Id], [HoTen], [Diachi], [SDT], [IdChucVuNV], [IdKVucLamViec], [NgayVaoLam], [Luong], [duongdanimg], [idTaiKhoan], [DisplayOrder]) VALUES (1, N'hoài bảo', NULL, NULL, 1, 1, CAST(N'2022-05-26T11:50:11.3676527' AS DateTime2), 200000, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([Id], [User], [PasswordHash], [PasswordSalt], [FullName], [IsAdmin], [IdRole], [CreateDate]) VALUES (1, N'admin', 0xF562991F118A4126C8C88477A5532481006CEA3C2BF06A6EB6DA8423232A56857ACFE3A882A5B2B1C78339BED235193B8A302D452654C96A2929C761B68B14D9, 0xE65F5D1EE210EC00CB441C6239EE2EB8B42757282D85A01049AEEA83F53447251A754896B0AF3C35A9A521C235277105E47599F25CB972CCF60411C760C92281ED5AE6F89F96062EDC1CCDB5EBD5ABC29EC60C8DE70F5EFFF3C15AC223C462449ADB5604DED4903D8E54AA588916FED3F82A4CB84557D3FDBFCDC25132299280, N'123', 1, 0, CAST(N'2022-05-10T12:59:07.6809779' AS DateTime2))
INSERT [dbo].[TaiKhoan] ([Id], [User], [PasswordHash], [PasswordSalt], [FullName], [IsAdmin], [IdRole], [CreateDate]) VALUES (2, N'hoaibao', 0xB003413A8E0430AAEECE2D7CAE71838AD20B758401885BD8B8BAB9DBAECF0973476D585EB2A5A6B0947E4F7C485961A620F8344FE5EBEB30AB2A57BBA54FD713, 0x0B17C0D80A982F84A707FBF8F576ABC0F8A1AF32B0B74FC327D926CFB2AE8E73651B52B84FFF03BD0C1923501F0F579B22CF02B13498256B05B96F195D2952F9CAD020EFB3B26F3322419C6CD249D5D18F31F22D46905D79D2BB1F4ABF43B25B3336A4DEF000B37013FF71B83B32C096E9EF07E754F8BDA451BCEFE0822BD470, N'Lê Trần Hoài Bảo', 0, NULL, CAST(N'2022-06-08T19:49:53.9902053' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[TheLoaiMenu] ON 

INSERT [dbo].[TheLoaiMenu] ([Id], [TheLoai], [DisplayOrder]) VALUES (1, N'Món chính', NULL)
INSERT [dbo].[TheLoaiMenu] ([Id], [TheLoai], [DisplayOrder]) VALUES (2, N'Thức ăn nhanh', NULL)
INSERT [dbo].[TheLoaiMenu] ([Id], [TheLoai], [DisplayOrder]) VALUES (3, N'Nước uống', NULL)
SET IDENTITY_INSERT [dbo].[TheLoaiMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[TrangThaiKho] ON 

INSERT [dbo].[TrangThaiKho] ([Id], [TrangThai], [DisplayOrder]) VALUES (1, N'Còn Hàng', NULL)
INSERT [dbo].[TrangThaiKho] ([Id], [TrangThai], [DisplayOrder]) VALUES (2, N'Hết hàng', NULL)
SET IDENTITY_INSERT [dbo].[TrangThaiKho] OFF
GO
ALTER TABLE [dbo].[DatBan] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Duyet]
GO
ALTER TABLE [dbo].[DatHang] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Duyet]
GO
ALTER TABLE [dbo].[MaHang] ADD  DEFAULT ((0)) FOR [TongSoLuong]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DatHang_IdDatHang] FOREIGN KEY([IdDatHang])
REFERENCES [dbo].[DatHang] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DatHang_IdDatHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_Menu_IdMenu] FOREIGN KEY([IdMenu])
REFERENCES [dbo].[Menu] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_Menu_IdMenu]
GO
ALTER TABLE [dbo].[DatBan]  WITH CHECK ADD  CONSTRAINT [FK_DatBan_TaiKhoan_IdTaiKhoan] FOREIGN KEY([IdTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[DatBan] CHECK CONSTRAINT [FK_DatBan_TaiKhoan_IdTaiKhoan]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_TaiKhoan_IdTaiKhoan] FOREIGN KEY([IdTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_TaiKhoan_IdTaiKhoan]
GO
ALTER TABLE [dbo].[KhoQuan]  WITH CHECK ADD  CONSTRAINT [FK_KhoQuan_MaHang_MahangId] FOREIGN KEY([MahangId])
REFERENCES [dbo].[MaHang] ([Id])
GO
ALTER TABLE [dbo].[KhoQuan] CHECK CONSTRAINT [FK_KhoQuan_MaHang_MahangId]
GO
ALTER TABLE [dbo].[KhoQuan]  WITH CHECK ADD  CONSTRAINT [FK_KhoQuan_TaiKhoan_idTaiKhoan] FOREIGN KEY([idTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[KhoQuan] CHECK CONSTRAINT [FK_KhoQuan_TaiKhoan_idTaiKhoan]
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
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_TaiKhoan_idTaiKhoan] FOREIGN KEY([idTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_TaiKhoan_idTaiKhoan]
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
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan_idTaiKhoan] FOREIGN KEY([idTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan_idTaiKhoan]
GO
