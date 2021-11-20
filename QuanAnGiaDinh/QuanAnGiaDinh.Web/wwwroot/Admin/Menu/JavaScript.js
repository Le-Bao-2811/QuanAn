

$(document).ready(function () {
	var dTable = $("#tbMenu").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/Menu/list",
		columns: [
			{ data: "id" },
			{ data: "thucDon" },
			{ data: "danhMucMenu.danhMuc" },
			{ data: "theLoaiMenu.theLoai" },
			{ data: "giaTien" },
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
			$.get("/admin/Menu/get", { id: id },
				function (data, textStatus, jsXHR) {
					form.find("#Id").val(data.id);
					form.find("#ChucVu").val(data.chucVu);
					form.find("#IdDanhMuc").val(data.idDanhMuc);
					form.find("#IdTheLoai").val(data.idTheThoai);
					form.find("#GiaTien").val(data.giaTien);
				},
				"json"
			)
		}
		modal.show();
		modal.setPrimaryButtonEvent(function (ev) {
			var data = new FormData(form[0]);
			$.ajax({
				url: "/Admin/Menu/_AddorUpdate",
				type: "POST",
				data: data,
				processData: false,
				contentType: false
			})
			.then(function (res) {
				dTable.draw(false);
				console.log(res);
			}).catch(function (err) {
				console.error(err);
			});			
			modal.hide();
		})
	});
	$(document).on("click", ".js-delete", function (ev) {
		var id = $(ev.currentTarget).closest("td").attr("data-id");
		confirm("Xác nhận xóa dư liệu", function () {
			$.ajax({
				type: "DELETE",
				url: "/admin/menu/delete",
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
