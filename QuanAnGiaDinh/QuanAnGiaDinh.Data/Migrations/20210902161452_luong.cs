using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class luong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Luong",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Luong",
                table: "NhanVien");
        }
    }
}
