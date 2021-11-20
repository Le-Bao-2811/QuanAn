using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class luong1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVuNV",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_KVLamViec_IdKVucLamViec",
                table: "NhanVien");

            migrationBuilder.AlterColumn<int>(
                name: "IdKVucLamViec",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdChucVuNV",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVuNV",
                table: "NhanVien",
                column: "IdChucVuNV",
                principalTable: "ChucVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_KVLamViec_IdKVucLamViec",
                table: "NhanVien",
                column: "IdKVucLamViec",
                principalTable: "KVLamViec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVuNV",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_KVLamViec_IdKVucLamViec",
                table: "NhanVien");

            migrationBuilder.AlterColumn<int>(
                name: "IdKVucLamViec",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdChucVuNV",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVuNV",
                table: "NhanVien",
                column: "IdChucVuNV",
                principalTable: "ChucVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_KVLamViec_IdKVucLamViec",
                table: "NhanVien",
                column: "IdKVucLamViec",
                principalTable: "KVLamViec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
