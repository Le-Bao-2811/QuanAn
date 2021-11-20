using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class reinitdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kg = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiKhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiKhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhoQuans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thucpham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTrangThai = table.Column<int>(type: "int", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    MahangId = table.Column<int>(type: "int", nullable: true),
                    ngaynhap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoQuans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoQuans_MaHangs_MahangId",
                        column: x => x.MahangId,
                        principalTable: "MaHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KhoQuans_TrangThaiKhos_IdTrangThai",
                        column: x => x.IdTrangThai,
                        principalTable: "TrangThaiKhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhoQuans_IdTrangThai",
                table: "KhoQuans",
                column: "IdTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_KhoQuans_MahangId",
                table: "KhoQuans",
                column: "MahangId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhoQuans");

            migrationBuilder.DropTable(
                name: "MaHangs");

            migrationBuilder.DropTable(
                name: "TrangThaiKhos");
        }
    }
}
