using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class monan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonAn",
                table: "DatBan");

            migrationBuilder.AddColumn<string>(
                name: "MonAn",
                table: "DatHang",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonAn",
                table: "DatHang");

            migrationBuilder.AddColumn<string>(
                name: "MonAn",
                table: "DatBan",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
