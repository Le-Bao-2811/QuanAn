$(document).ready(function () {
	var Dtable = $("#tbTrangThaiKho").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/trangthaikho/list",
		columns: [
			{ data: "id" },
			{ data: "trangThai" },
			{ data: null, defaultContent: $(".js-placeholder").html() }
		],
	});
	$(document).on("click", ".js-add-or-update", function (ev) {
		var id = 0;
		var modal = new Modal("AddorUpdate", "Thêm danh mục");
		modal.clearBody();
		modal.appendBody($("#_AddorUpdate").html());
		modal.setDefaultFooterButton("Lưu", "Hủy");
		var form = modal.modalBody.find("form");
		//update
		if ($(ev.currentTarget.parentElement.parentElement).attr('update') == '') {
			id = $(ev.currentTarget).closest("td").attr("data-id");
			modal.setTitle("Cập nhật danh mục");
			//get data update
			$.get("/admin/trangthaikho/get", { id: id },
				function (data, textStatus, jqXHR) {
					form.find("#Id").val(data.id);
					form.find("#TrangThai").val(data.trangthai);
				},
				"json"
			)
		}
		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = form.serialize();
			$.post("/Admin/TrangThaiKho/_AddorUpdate", data,
				function (data, textStatus, jqXHR) {
					if (data == true) {
						Dtable.draw(false);
						modal.hide();
					}
				},
				"json"
			);
		});
	});
});