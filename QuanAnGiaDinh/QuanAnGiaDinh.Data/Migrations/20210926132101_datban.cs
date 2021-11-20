using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class datban : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatBan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatBan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatBan");
        }
    }
}
