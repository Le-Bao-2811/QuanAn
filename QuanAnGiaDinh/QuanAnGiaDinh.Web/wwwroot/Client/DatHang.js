window.addEventListener("load", () => {
	const allCookie = document.cookie;
	const cookieArray = allCookie.split(';');
	var newArrayCookie = [];
	for (var i = 0; i < cookieArray.length; i++) {
		if (cookieArray[i].indexOf("products_") != -1) {
			newArrayCookie.push(parseInt(cookieArray[i].replace("products_", "").split("=")[0].trim()));
		}
	};
	$.post('/tab/cart', { idList: newArrayCookie }, function (data, a, b) {
		if (data.length > 0) {
			const tbody = document.querySelector("#load-products");
			tbody.innerHTML = "";
			const total = document.querySelector('#total-listcart');
			total.innerHTML = "";
		
			var totalgiatien = 0;
			for (var i = 0; i < data.length; i++) {
				const { giaTien, thucDon, hinh, duongdan, id } = data[i];
				var gia = giaTien * getCookie("products_" + id);
				totalgiatien = totalgiatien + gia
				var html = `<div class="card mb-3">
									<div class="card-body">
										<div class="d-flex justify-content-between">
											<div class="d-flex flex-row align-items-center">
												<div>
													<img src="/img/menu/${duongdan}"
														 class="img-fluid rounded-3"
														 alt="Shopping item"
														 style="width: 65px" />
												</div>
												<div class="ms-3">
													<h5>${thucDon}</h5>
												</div>
											</div>
											<div class="d-flex flex-row align-items-center">
												<div style="width: 50px">
													<h5 class="fw-normal mb-0">${getCookie("products_" + id)}</h5>
												</div>
												<div style="width: 126px">
													<h5 class="mb-0">${gia.toLocaleString('de-DE')} VNĐ</h5>													
												</div>
												<a href="#!" style="color: #cecece">
													<i class="fas fa-trash-alt"></i>
												</a>
											</div>
										</div>
									</div>
								</div>`;
				var htmltotalprice = `
					<div class="d-flex justify-content-between">
						<p class="mb-2">${thucDon}</p>
						<p class="mb-2">${gia.toLocaleString("de-DE")} <span>VNĐ</span></p>
					</div>
				`
				tbody.insertAdjacentHTML('beforeend', html)
				total.insertAdjacentHTML('beforeend', htmltotalprice)
			}
			
		}
	});
	$(document).on('click', '.dathang', (ev) => {
		ev.preventDefault();
		var name = document.querySelector(".name").value
		var diachi = document.querySelector(".diachi").value
		var sdt = document.querySelector(".sdt").value
		var model = {
			TenKH: name,
			DiaChi: diachi,
			SDT:sdt
		}
		$.post("/home/_addDatHang", model, (data, textStatus, jqXHR) => {
			if (data == true) {
				Swal.fire(
					'Đặt hàng thành công',
					'Ấn ok tiếp tục!',
					'success'
				).then(() => {
					window.location.href="/home/index"
                }) 
            }
		})
    })
	function setCookie(cname, cvalue, exdays) {
		var d = new Date();
		d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
		var expires = "expires=" + d.toUTCString();
		document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
	}
	function getCookie(cname) {
		var name = cname + "=";
		var decodedCookie = decodeURIComponent(document.cookie);
		var ca = decodedCookie.split(';');
		for (var i = 0; i < ca.length; i++) {
			var c = ca[i];
			while (c.charAt(0) == ' ') {
				c = c.substring(1);
			}
			if (c.indexOf(name) == 0) {
				return c.substring(name.length, c.length);
			}
		}
		return "";
	}
})