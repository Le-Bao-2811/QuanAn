using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonAn",
                table: "DatHang");

            migrationBuilder.AddColumn<string>(
                name: "Diachi",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SDT",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "duongdanimg",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TongSoLuong",
                table: "KhoQuan",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropColumn(
                name: "Diachi",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "SDT",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "duongdanimg",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TongSoLuong",
                table: "KhoQuan");

            migrationBuilder.AddColumn<string>(
                name: "MonAn",
                table: "DatHang",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
