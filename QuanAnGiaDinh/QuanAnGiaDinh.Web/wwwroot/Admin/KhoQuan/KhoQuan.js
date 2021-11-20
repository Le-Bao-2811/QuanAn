
$(document).ready(function () {
	var dTable = $("#tbKhoQuan").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/khoquan/list",
		columns: [
			{ data: "id" },
			{ data: "thucpham" },
			{ data: "trangThaiKho.trangThai" },
			{ data: "soluong" },
			{ data: "maHang.loaiHang" },
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
			$.get("/admin/khoQuan/get", { id: id },
				function (data, textStatus, jqXHR) {
					form.find("#Id").val(data.id);
					form.find("#ThucPham").val(data.thucPham);
					form.find("#IdTrangThai").val(data.idTrangThai);
					form.find("#Soluong").val(data.soluong);
					form.find("#MahangId").val(data.mahangId);
				},
				"json"
			)
		}

		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = form.serialize();
			
			console.log(data);
			$.post("/admin/khoquan/addorUpdate", data,
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

	$(document).on("click", ".js-delete", function (ev) {
		var id = $(ev.currentTarget).closest("td").attr("data-id");
		confirm("Xác nhận xóa dư liệu", function () {
			$.ajax({
				type: "DELETE",
				url: "/admin/khoquan/delete",
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