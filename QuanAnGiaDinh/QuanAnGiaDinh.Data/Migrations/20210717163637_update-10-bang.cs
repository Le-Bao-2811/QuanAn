using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class update10bang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChucVuNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KVLamViecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KVucLamViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KVLamViecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoaiMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheLoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XuatKhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thucpham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTrangThai = table.Column<int>(type: "int", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    MahangId = table.Column<int>(type: "int", nullable: true),
                    NgayXuatKho = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XuatKhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdChucVuNV = table.Column<int>(type: "int", nullable: false),
                    IdKVucLamViec = table.Column<int>(type: "int", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChucVus_IdChucVuNV",
                        column: x => x.IdChucVuNV,
                        principalTable: "ChucVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanViens_KVLamViecs_IdKVucLamViec",
                        column: x => x.IdKVucLamViec,
                        principalTable: "KVLamViecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThucDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDanhMuc = table.Column<int>(type: "int", nullable: true),
                    IdTheLoai = table.Column<int>(type: "int", nullable: true),
                    GiaTien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_DanhMucMenus_IdDanhMuc",
                        column: x => x.IdDanhMuc,
                        principalTable: "DanhMucMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Menus_TheLoaiMenus_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoaiMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_IdDanhMuc",
                table: "Menus",
                column: "IdDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_IdTheLoai",
                table: "Menus",
                column: "IdTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdChucVuNV",
                table: "NhanViens",
                column: "IdChucVuNV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdKVucLamViec",
                table: "NhanViens",
                column: "IdKVucLamViec");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "XuatKhos");

            migrationBuilder.DropTable(
                name: "DanhMucMenus");

            migrationBuilder.DropTable(
                name: "TheLoaiMenus");

            migrationBuilder.DropTable(
                name: "ChucVus");

            migrationBuilder.DropTable(
                name: "KVLamViecs");
        }
    }
}
