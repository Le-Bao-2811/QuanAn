using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class xoarole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChucVuNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KVLamViec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KVucLamViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KVLamViec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSoLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoaiMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheLoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiKho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiKho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatBan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatBan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatBan_TaiKhoan_IdTaiKhoan",
                        column: x => x.IdTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sotien = table.Column<int>(type: "int", nullable: false),
                    ThoiGianDatHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatHang_TaiKhoan_IdTaiKhoan",
                        column: x => x.IdTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdChucVuNV = table.Column<int>(type: "int", nullable: true),
                    IdKVucLamViec = table.Column<int>(type: "int", nullable: true),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luong = table.Column<int>(type: "int", nullable: false),
                    duongdanimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVuNV",
                        column: x => x.IdChucVuNV,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_KVLamViec_IdKVucLamViec",
                        column: x => x.IdKVucLamViec,
                        principalTable: "KVLamViec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_TaiKhoan_idTaiKhoan",
                        column: x => x.idTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThucDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDanhMuc = table.Column<int>(type: "int", nullable: true),
                    IdTheLoai = table.Column<int>(type: "int", nullable: true),
                    idTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    GiaTien = table.Column<int>(type: "int", nullable: false),
                    duongdan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLDaBan = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_DanhMucMenu_IdDanhMuc",
                        column: x => x.IdDanhMuc,
                        principalTable: "DanhMucMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Menu_TaiKhoan_idTaiKhoan",
                        column: x => x.idTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Menu_TheLoaiMenu_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoaiMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhoQuan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thucpham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTrangThai = table.Column<int>(type: "int", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    MahangId = table.Column<int>(type: "int", nullable: true),
                    idTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    ngaynhap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongSoLuong = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoQuan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoQuan_MaHang_MahangId",
                        column: x => x.MahangId,
                        principalTable: "MaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KhoQuan_TaiKhoan_idTaiKhoan",
                        column: x => x.idTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KhoQuan_TrangThaiKho_IdTrangThai",
                        column: x => x.IdTrangThai,
                        principalTable: "TrangThaiKho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    IdDatHang = table.Column<int>(type: "int", nullable: false),
                    IdMenu = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => new { x.IdDatHang, x.IdMenu });
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DatHang_IdDatHang",
                        column: x => x.IdDatHang,
                        principalTable: "DatHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_Menu_IdMenu",
                        column: x => x.IdMenu,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_IdMenu",
                table: "ChiTietDonHang",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_DatBan_IdTaiKhoan",
                table: "DatBan",
                column: "IdTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_DatHang_IdTaiKhoan",
                table: "DatHang",
                column: "IdTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_KhoQuan_idTaiKhoan",
                table: "KhoQuan",
                column: "idTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_KhoQuan_IdTrangThai",
                table: "KhoQuan",
                column: "IdTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_KhoQuan_MahangId",
                table: "KhoQuan",
                column: "MahangId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_IdDanhMuc",
                table: "Menu",
                column: "IdDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_idTaiKhoan",
                table: "Menu",
                column: "idTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_IdTheLoai",
                table: "Menu",
                column: "IdTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVuNV",
                table: "NhanVien",
                column: "IdChucVuNV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdKVucLamViec",
                table: "NhanVien",
                column: "IdKVucLamViec");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_idTaiKhoan",
                table: "NhanVien",
                column: "idTaiKhoan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "DatBan");

            migrationBuilder.DropTable(
                name: "KhoQuan");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "DatHang");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MaHang");

            migrationBuilder.DropTable(
                name: "TrangThaiKho");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "KVLamViec");

            migrationBuilder.DropTable(
                name: "DanhMucMenu");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "TheLoaiMenu");
        }
    }
}
