$(document).ready(function () {
	var dTable = $("#tbNhanVien").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/nhanvien/list",
		columns: [
			{ data: "id" },
			{ data: "hoTen" },
			{ data: "chucVu.chucVuNV" },
			{ data: "kVLamViec.kVucLamViec" },
			{ data: "luong" },
			{ data: null, defaultContent: $(".js-placeholder").html() }
		],
	});
	$(document).on("click", ".js-add-or-update", function (ev) {
		var id = 0;
		var modal = new Modal("#AddorUpdate", "Thêm Nhân Viên");
		modal.clearBody();
		modal.appendBody($('#_AddorUpdate').html());
		modal.setDefaultFooterButton("Lưu", "Hủy");
		var form = modal.modalBody.find("form");
		//update
		if ($(ev.currentTarget.parentElement.parentElement).attr('update') == '') {
			id = $(ev.currentTarget).closest("td").attr("data-id");
			modal.setTitle("Cập nhật nhân viên");
			// lấy dữ liêu cũ để update
			$.get("/admin/nhanvien/get", { id: id },
				function (data, textStatus, jqXHR) {
					form.find("#Id").val(data.id);
					form.find("#Hoten").val(data.hoTen);
					form.find("#ChucVuNhanVien").val(data.chucVuNV);
					form.find("#KVucLamViec").val(data.kVucLamViec);
					form.find("#Luong").val(data.luong);

				},
				"json"
			)
		}

		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = form.serialize();
			console.log(data);
			$.post("/admin/nhanvien/_addorupdate", data,
				function (data, textStatus, jqXHR) {
					if (data == true) {
						dTable.draw(false);
						modal.hide();
					}
				},
				"json"
			);
		});
	});;
});
