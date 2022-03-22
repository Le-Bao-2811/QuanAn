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
			console.log(tbody);
			for (var i = 0; i < data.length; i++) {
				const { giaTien, thucDon, hinh, duongdan, id } = data[i];
				
				var html = `<tr>
						<td style="display: flex; align-items: center;"><img style="width:70px" src="/img/menu/${duongdan}" alt=""><p class="menu-cart">${thucDon}</p></td>
						<td> <p><span class="abc">${giaTien}</span><sup>đ</sup></p></td>
						<td><input class="input" style="width:30px;outline:none;" type="number" value="${getCookie('products_'+id)}" min="1"></td>
						<td style="cursor: pointer;">Xóa</td>
					</tr>`;
				tbody.insertAdjacentHTML('beforeend', html);
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