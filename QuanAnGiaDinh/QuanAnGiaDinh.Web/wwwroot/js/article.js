/*
 * Author: DTeam 2021
 * Xử lý sự kiện cho trang article
 */

// Dữ liệu cho thao tác thêm/sửa bài viết
const articleData = {
	url: '',
	data: null,
	message: {
		success: '',
		error: ''
	}
};

$(document).ready(function () {
	// Khởi tạo datatable
	window.dTable = $("#tbArticle").DataTable({
		processing: true,
		serverSide: true,
		ajax: "/admin/Article/list",
		columns: [
			{ data: "id" },
			{ data: "title" },
			{ data: "statusName" },
			{ data: "categoryName" },
			{ data: "viewsCount" },
			{ data: null, defaultContent: $(".js-placeholder").html() }
		],
	});
});

/*
 * minhtt
 * 10/5/2021
 * Hàm hiển thị modal trong giao diện thêm bài viết
 */
$(document).ready(function () {
	window.modal = new Modal("addArticle");
	modal.clearBody();
	modal.setTitle("Thêm bài viết");
	$("#_AddOrUpdateArticle").removeClass('d-none').appendTo(modal.modalBody);
	modal.setDefaultFooterButton("Lưu", "Hủy");
	// Sử dụng full màn hình
	modal.useFullScreenSize();
	// Không dùng nút Esc để tắt modal
	modal.setOption(false, false);

	// Sự kiện click khi nhấn nút lưu
	modal.setPrimaryButtonEvent(function (ev) {
		var form = modal.modalBody.find("form");
		articleData.data = form.serialize();
		$.post(articleData.url, articleData.data,
			function (data, textStatus, jqXHR) {
				if (data == true) {
					modal.hide();
					window.dTable.draw(false);
					Toast.success(articleData.message.success);
					form.trigger('reset');
				}
				else {
					Toast.danger(articleData.message.error);
				}
			},
			"json"
		);
	});
	/*
	 * minhtt
	 * 19/06/2021
	 * Hàm hiển thị summernote cho nội dung thêm bài viết
	 */
	$('#Content').summernote({
		tabsize: 2,
		height: 300,
		toolbar: [
			['style', ['style']],
			['font', ['bold', 'underline', 'clear']],
			['color', ['color']],
			['para', ['ul', 'ol', 'paragraph']],
			['table', ['table']],
			['insert', ['link', 'picture', 'video']],
			['view', ['fullscreen', 'codeview', 'help']]
		],
		lang:"vi-VN" 
	});

	// Custom modal trong summernote - fix chức năng đóng modal
	var noteModals = $(".note-modal");
	noteModals.each((i, item) => {
		var btnClose = $(item).find(".modal-header>.close");
		btnClose.removeAttr("data-dismiss");
		btnClose.click(() => {
			$(item).modal("hide");
		});
	});

	// class "js-add" được đặt ở nút thêm
	$(document).on("click", ".js-add", function (ev) {
		modal.show();
	});
});

// Sự kiện click của nút thêm mới
$(document).on("click", '.js-add', function (ev) {
	articleData.url = "/admin/article/add";
	articleData.message.success = "Thêm bài viết thành công";
	articleData.message.error = "Thêm bài viết thất bại";
	modal.modalBody.find("form #Id").val('');	// Xóa id khi nhấn thêm mới
	modal.show();
});

// Sự kiện click của nút sửa bài viết
$(document).on("click", ".js-update", function (ev) {
	var tdElement = $(ev.currentTarget).closest("td");
	id = tdElement.attr("data-id");
	modal.setTitle("Sửa bài viết");
	var form = modal.modalBody.find("form");
	// Get data for update
	$.get("/admin/article/get", { id: id },
		function (data, textStatus, jqXHR) {
			form.find("#Id").val(data.id);
			form.find("#Title").val(data.title);
			form.find("#URL").val(data.url);
			form.find("#Summary").val(data.summary);
			form.find("#Content").val(data.content);
			form.find("#ThumbnailPath").val(data.thumbnailPath);
			form.find("#ArticleStatusId").val(data.articleStatusId);
			form.find("#CanComment").val(data.canComment);
			form.find("#DisplayOrder").val(data.displayOrder);
		},
		"json"
	);
	articleData.url = "/admin/article/update";
	articleData.message.success = "Cập nhật bài viết thành công";
	articleData.message.error = "Cập nhật bài viết thất bại";
	modal.show();
});
// Tạo đường dẫn tự động
const createStringUrl = (event) => {
	var title = $(event.currentTarget);
	var url = $("#URL");
	var titleValue = title.val();
	var str = convertTitleToUrl(titleValue);
	url.val(str);
}

// Kiểm tra checkbox
const enableUseUrl = () => {
	var title = $("#Title");
	var url = $("#URL");
	var checkedUseUrl = document.getElementById("checkedUseUrl");
	if (checkedUseUrl.checked) {
		url.attr('readonly', true);
		url.val(convertTitleToUrl(title.val()));
		title.attr('oninput', 'createStringUrl(event)');
	} else {
		url.attr('readonly', false);
		title.removeAttr('oninput');
	}
}

// Chuyển chuỗi tiếng việt có dấu sang không dấu
const convertTitleToUrl = (str) => {
	str = str.normalize("NFD")
		.trim()
		.replace(/[`~!@#$%^&*()_|+\-=?;:'",.<>\{\}\[\]\\\/\u0300-\u036f]/gi, '')
		.replace(/đ/g,'d')
		.replace(/Đ/g, 'D')
		.replace(/\s+/g, "-");
	return str;
}
/*
* hbao
* Xóa bài viết
*/
$(document).on("click", ".js-delete", function (ev) {
	var id = $(ev.currentTarget).closest("td").attr("data-id");
	confirm('Xác nhận xóa dữ liệu', function () {
		$.ajax({
			type: "DELETE",
			url: "/admin/article/delete",
			data: { id: id },
			dataType: "json",
			success: function (response) {
				if (response == true) {
					dTable.draw(false);
				}
				else {
					alert('Đã xảy ra lỗi, không thể thực hiện thao tác này');
				}
			}
		});
	});
});