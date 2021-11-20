
//const callData = () => {
//	axios.get("/home/menuclient").then(reponese => {
//		var data = reponese.data;
//		console.log(data)
//	});
//}
//const appendData = (data) => {
//	document.querySelector(".menu").textContent = "";
//	let result = data;
//	for (var i = 0; i < result.length; i++) {
//		const { dsplay, gia, hinh, id, idmm, idtlmenu, thucdon, duongdan } = result[i]
//		let html = `<div class="col-lg-3 col-md-6">
//				<div class="team-item">
//					<div class="team-img">
//						<img src="~/Layout/img/team-4.jpg" alt="Image">

//					</div>
//					<div class="team-text">
//						<h2>${thucdon}</h2>
//						<p>${gia}</p>
//					</div>
//				</div>
//			</div>`;
//		document.querySelector(".menu").insertAdjacentHTML('beforeend', html);
//	}
//}
$(document).on("click", ".datban", function () {
	var data = $("#form-datban").serialize()

	console.log(data);
	$.post("/home/add", data,
		function (data, textStatus, jqXHR) {
			if (data == true) {
				alert("Đặt bàn thành công, nhân viên quán sẽ sớm gọi xác nhận đến bạn")
			}
			else {
				alert("Thất bại");
			}
		},
		"json"
	);
});

$(document).on("click", "#buy", function (ev) {


	//lấy tổng tiền bên giỏ hàng
	var tongtien = document.querySelector(".money-modal")//Lấy ra cái thẻ input
	var money = document.querySelector(".money-cart").innerHTML //Lấy đc 1 con số ví dụ 123
	console.log(tongtien)
	tongtien.value = money
	

	var menu = document.querySelectorAll(".menu-cart")
	var monan = "";
	for (var i = 0; i < menu.length; i++) {
		if (i == menu.length - 1) {
			monan = monan + menu[i].innerHTML;
		}
		else {
			monan = monan + menu[i].innerHTML + ",";
		}

	}
	var inputmenu = document.querySelector(".input-menu")
	inputmenu.value = monan
	
	
	
})
$(document).on("click", ".dathang", function () {
	var data = $('#form-dathang').serialize()
	$.post("/home/_adddathang", data, function (data, textStatus, jqXHR) {
		if (data = true) {
			alert("Cập nhật thành công");
			setInterval(() => {
				location.reload()
			}, 1000)
		}
		else {
			alert("Cập nhật thất bại")
		}
	})
	
})
