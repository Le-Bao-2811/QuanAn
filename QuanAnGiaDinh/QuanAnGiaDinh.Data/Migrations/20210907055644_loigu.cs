using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class loigu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Menu",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Menu");
        }
    }
}
