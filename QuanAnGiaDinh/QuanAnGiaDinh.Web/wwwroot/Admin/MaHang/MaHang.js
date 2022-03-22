
$(document).ready(function () {
	var dTable = $("#tbMaHang").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/mahang/list",
		columns: [
			{ data: "id" },
			{ data: "loaiHang" },
			{ data: null, defaultContent: $(".js-placeholder").html() }
		],
	});
	$(document).on("click", ".js-add-or-update", function (ev) {
		var id = 0;
		var modal = new Modal("AddorUpdate", "Thêm danh mục");
		modal.clearBody();
		modal.appendBody($('#_AddorUpdate').html());
		modal.setDefaultFooterButton("Lưu", "Hủy");
		var form = modal.modalBody.find("form");
		//update
		if ($(ev.currentTarget.parentElement.parentElement).attr('update') == '') {
			id = $(ev.currentTarget).closest("td").attr("data-id");
			modal.setTitle("Cập nhập danh mục");
			//get data update
			$.get("/Admin/MaHang/Get", { id: id },
				function (data, textStatus, jqXHR) {
					form.find("#Id").val(data.id);
					form.find("#LoaiHang").val(data.loaiHang);
					form.find("#Kg").val(data.kg);
				},
				"json"
			)
		}
		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = form.serialize();
			$.post("/Admin/MaHang/_AddorUpdate", data,
				function (data, textStatus, jqXHR) {
					if (data == true) {
						dTable.draw(false);
						modal.hide();
					}
				},
				"json"
			);
		});
	});
	$(document).on('click', '.js-delete', function (ev) {
		var id = $(ev.currentTarget).closest("td").attr("data-id");
		// custom confirm
		confirm('Xác nhận xóa dữ liệu', function () {
			$.ajax({
				type: "DELETE",
				url: "/admin/mahang/delete",
				data: { id: id },
				dataType: "json",
				success: function (response) {
					if (response == true) {
						Toast.success("Xóa dữ liệu thành công"),
						dTable.draw(false);
					}
					else {
						alert('Đã xảy ra lỗi, không thể thực hiện thao tác này');
					}
				}
			});
		});
	});
});