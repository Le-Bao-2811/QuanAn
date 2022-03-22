using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class khoangoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idTaiKhoan",
                table: "NhanVien",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTaiKhoan",
                table: "Menu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTaiKhoan",
                table: "KhoQuan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTaiKhoan",
                table: "DatHang",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_idTaiKhoan",
                table: "NhanVien",
                column: "idTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_idTaiKhoan",
                table: "Menu",
                column: "idTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_KhoQuan_idTaiKhoan",
                table: "KhoQuan",
                column: "idTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_DatHang_IdTaiKhoan",
                table: "DatHang",
                column: "IdTaiKhoan");

            migrationBuilder.AddForeignKey(
                name: "FK_DatHang_TaiKhoan_IdTaiKhoan",
                table: "DatHang",
                column: "IdTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KhoQuan_TaiKhoan_idTaiKhoan",
                table: "KhoQuan",
                column: "idTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_TaiKhoan_idTaiKhoan",
                table: "Menu",
                column: "idTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_TaiKhoan_idTaiKhoan",
                table: "NhanVien",
                column: "idTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatHang_TaiKhoan_IdTaiKhoan",
                table: "DatHang");

            migrationBuilder.DropForeignKey(
                name: "FK_KhoQuan_TaiKhoan_idTaiKhoan",
                table: "KhoQuan");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_TaiKhoan_idTaiKhoan",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_TaiKhoan_idTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_idTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_Menu_idTaiKhoan",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_KhoQuan_idTaiKhoan",
                table: "KhoQuan");

            migrationBuilder.DropIndex(
                name: "IX_DatHang_IdTaiKhoan",
                table: "DatHang");

            migrationBuilder.DropColumn(
                name: "idTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "idTaiKhoan",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "idTaiKhoan",
                table: "KhoQuan");

            migrationBuilder.DropColumn(
                name: "IdTaiKhoan",
                table: "DatHang");
        }
    }
}
