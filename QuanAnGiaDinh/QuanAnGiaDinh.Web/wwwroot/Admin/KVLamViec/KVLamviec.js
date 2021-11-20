$(document).ready(function () {
	var dTable = $("#tbKVLV").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/KVLamViec/list",
		columns: [
			{ data: "id" },
			{ data: "kVucLamViec" },
			{ data: null, defaultContent: $(".js-placeholder").html() }
		],
	});
	$(document).on("click", ".js-add-or-update", function (ev) {
		var id = 0;
		var modal = new Modal("AddorUpdate", "Khu Vực làm việc");
		modal.clearBody();
		modal.appendBody($("#_AddorUpdate").html());
		modal.setDefaultFooterButton("Lưu", "Hủy");
		var form = modal.modalBody.find("form");
		//update
		if ($(ev.currentTarget.parentElement.parentElement).attr('update') == '') {
			id = $(ev.currentTarget).closest("td").attr("data-id");
			$.get("/admin/kVLamViec/get", { id: id },
				function (data, textStatus, jsXHR) {
					form.find("#Id").val(data.id);
					form.find("#KVucLamViec").val(data.kVucLamViec);
				},
				"json"
			)
		}
		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = form.serialize();
			$.post("/Admin/KVLamviec/_AddorUpdate", data,
				function (data, textStatus, jqXHR) {
					if (data == true) {
						dTable.draw(false);
						modal.hide();
					}
				},
				"json"
			);
		})
	});
	$(document).on("click", ".js-delete", function (ev) {
		var id = $(ev.currentTarget).closest("td").attr("data-id");
		confirm("Xác nhận xóa dư liệu", function () {
			$.ajax({
				type: "DELETE",
				url: "/admin/kvlamviec/delete",
				data: { id: id },
				dataType: "json",
				success: function (reponse) {
					if (reponse == true) {
						Toast.success("Đã xóa thành công");
						dTable.draw(false);
					}
					else {
						Toast.danger("Xóa dữ liệu thất bại")
					}
				}
			});
		});
	});
});
