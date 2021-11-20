using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanAnGiaDinh.Data.Migrations
{
    public partial class taolaidatabase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhoQuans_MaHangs_MahangId",
                table: "KhoQuans");

            migrationBuilder.DropForeignKey(
                name: "FK_KhoQuans_TrangThaiKhos_IdTrangThai",
                table: "KhoQuans");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_DanhMucMenus_IdDanhMuc",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_TheLoaiMenus_IdTheLoai",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_ChucVus_IdChucVuNV",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_KVLamViecs_IdKVucLamViec",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_XuatKhos",
                table: "XuatKhos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrangThaiKhos",
                table: "TrangThaiKhos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoaiMenus",
                table: "TheLoaiMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaHangs",
                table: "MaHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KVLamViecs",
                table: "KVLamViecs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhoQuans",
                table: "KhoQuans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucMenus",
                table: "DanhMucMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChucVus",
                table: "ChucVus");

            migrationBuilder.RenameTable(
                name: "XuatKhos",
                newName: "XuatKho");

            migrationBuilder.RenameTable(
                name: "TrangThaiKhos",
                newName: "TrangThaiKho");

            migrationBuilder.RenameTable(
                name: "TheLoaiMenus",
                newName: "TheLoaiMenu");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");

            migrationBuilder.RenameTable(
                name: "MaHangs",
                newName: "MaHang");

            migrationBuilder.RenameTable(
                name: "KVLamViecs",
                newName: "KVLamViec");

            migrationBuilder.RenameTable(
                name: "KhoQuans",
                newName: "KhoQuan");

            migrationBuilder.RenameTable(
                name: "DanhMucMenus",
                newName: "DanhMucMenu");

            migrationBuilder.RenameTable(
                name: "ChucVus",
                newName: "ChucVu");

            migrationBuilder.RenameIndex(
                name: "IX_NhanViens_IdKVucLamViec",
                table: "NhanVien",
                newName: "IX_NhanVien_IdKVucLamViec");

            migrationBuilder.RenameIndex(
                name: "IX_NhanViens_IdChucVuNV",
                table: "NhanVien",
                newName: "IX_NhanVien_IdChucVuNV");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_IdTheLoai",
                table: "Menu",
                newName: "IX_Menu_IdTheLoai");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_IdDanhMuc",
                table: "Menu",
                newName: "IX_Menu_IdDanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_KhoQuans_MahangId",
                table: "KhoQuan",
                newName: "IX_KhoQuan_MahangId");

            migrationBuilder.RenameIndex(
                name: "IX_KhoQuans_IdTrangThai",
                table: "KhoQuan",
                newName: "IX_KhoQuan_IdTrangThai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_XuatKho",
                table: "XuatKho",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrangThaiKho",
                table: "TrangThaiKho",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoaiMenu",
                table: "TheLoaiMenu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaHang",
                table: "MaHang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KVLamViec",
                table: "KVLamViec",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhoQuan",
                table: "KhoQuan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucMenu",
                table: "DanhMucMenu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChucVu",
                table: "ChucVu",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoQuan_MaHang_MahangId",
                table: "KhoQuan",
                column: "MahangId",
                principalTable: "MaHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KhoQuan_TrangThaiKho_IdTrangThai",
                table: "KhoQuan",
                column: "IdTrangThai",
                principalTable: "TrangThaiKho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_DanhMucMenu_IdDanhMuc",
                table: "Menu",
                column: "IdDanhMuc",
                principalTable: "DanhMucMenu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_TheLoaiMenu_IdTheLoai",
                table: "Menu",
                column: "IdTheLoai",
                principalTable: "TheLoaiMenu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhoQuan_MaHang_MahangId",
                table: "KhoQuan");

            migrationBuilder.DropForeignKey(
                name: "FK_KhoQuan_TrangThaiKho_IdTrangThai",
                table: "KhoQuan");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_DanhMucMenu_IdDanhMuc",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_TheLoaiMenu_IdTheLoai",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVuNV",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_KVLamViec_IdKVucLamViec",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_XuatKho",
                table: "XuatKho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrangThaiKho",
                table: "TrangThaiKho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoaiMenu",
                table: "TheLoaiMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaHang",
                table: "MaHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KVLamViec",
                table: "KVLamViec");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhoQuan",
                table: "KhoQuan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucMenu",
                table: "DanhMucMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChucVu",
                table: "ChucVu");

            migrationBuilder.RenameTable(
                name: "XuatKho",
                newName: "XuatKhos");

            migrationBuilder.RenameTable(
                name: "TrangThaiKho",
                newName: "TrangThaiKhos");

            migrationBuilder.RenameTable(
                name: "TheLoaiMenu",
                newName: "TheLoaiMenus");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");

            migrationBuilder.RenameTable(
                name: "MaHang",
                newName: "MaHangs");

            migrationBuilder.RenameTable(
                name: "KVLamViec",
                newName: "KVLamViecs");

            migrationBuilder.RenameTable(
                name: "KhoQuan",
                newName: "KhoQuans");

            migrationBuilder.RenameTable(
                name: "DanhMucMenu",
                newName: "DanhMucMenus");

            migrationBuilder.RenameTable(
                name: "ChucVu",
                newName: "ChucVus");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_IdKVucLamViec",
                table: "NhanViens",
                newName: "IX_NhanViens_IdKVucLamViec");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_IdChucVuNV",
                table: "NhanViens",
                newName: "IX_NhanViens_IdChucVuNV");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_IdTheLoai",
                table: "Menus",
                newName: "IX_Menus_IdTheLoai");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_IdDanhMuc",
                table: "Menus",
                newName: "IX_Menus_IdDanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_KhoQuan_MahangId",
                table: "KhoQuans",
                newName: "IX_KhoQuans_MahangId");

            migrationBuilder.RenameIndex(
                name: "IX_KhoQuan_IdTrangThai",
                table: "KhoQuans",
                newName: "IX_KhoQuans_IdTrangThai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_XuatKhos",
                table: "XuatKhos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrangThaiKhos",
                table: "TrangThaiKhos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoaiMenus",
                table: "TheLoaiMenus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaHangs",
                table: "MaHangs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KVLamViecs",
                table: "KVLamViecs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhoQuans",
                table: "KhoQuans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucMenus",
                table: "DanhMucMenus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChucVus",
                table: "ChucVus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoQuans_MaHangs_MahangId",
                table: "KhoQuans",
                column: "MahangId",
                principalTable: "MaHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KhoQuans_TrangThaiKhos_IdTrangThai",
                table: "KhoQuans",
                column: "IdTrangThai",
                principalTable: "TrangThaiKhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_DanhMucMenus_IdDanhMuc",
                table: "Menus",
                column: "IdDanhMuc",
                principalTable: "DanhMucMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_TheLoaiMenus_IdTheLoai",
                table: "Menus",
                column: "IdTheLoai",
                principalTable: "TheLoaiMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_ChucVus_IdChucVuNV",
                table: "NhanViens",
                column: "IdChucVuNV",
                principalTable: "ChucVus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_KVLamViecs_IdKVucLamViec",
                table: "NhanViens",
                column: "IdKVucLamViec",
                principalTable: "KVLamViecs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
