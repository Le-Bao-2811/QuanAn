$(document).ready(function () {

	var dTable = $("#tbChucVu").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/chucvu/list",
		columns: [
			{ data: "id" },
			{ data: "chucVuNV" },
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
		console.log(form)
		//update
		if ($(ev.currentTarget.parentElement.parentElement).attr('update') == '') {
			id = $(ev.currentTarget).closest("td").attr("data-id");
			modal.setTitle("Cập nhập danh mục");
			//get data update
			$.get("/admin/chucvu/get", { id: id },
				function (data, textStatus, jqXHR) {
					form.find("#Id").val(data.id);
					form.find("#ChucVu").val(data.chucVu);
				},
				"json"
			)
		}

		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = form.serialize();

			console.log(data);
			$.post("/admin/chucvu/_addorUpdate", data,
				function (data, textStatus, jqXHR) {
					if (data == true) {
						dTable.draw(false);
						modal.hide();
					}
					else {
						alert("Thất bại");
					}
				},
				"json"
			);
		});
	});
	$(document).on("click", ".js-delete", function (ev) {
		var id = $(ev.currentTarget).closest("td").attr("data-id");
		confirm("Xác nhận xóa dư liệu", function () {
			$.ajax({
				type: "DELETE",
				url: "/admin/chucvu/delete",
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
})