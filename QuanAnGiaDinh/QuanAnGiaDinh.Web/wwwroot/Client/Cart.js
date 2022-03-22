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


const split = () => {
	var cookieString = document.cookie.split(';');

	var intArr = [];

	for (var i = 0; i < cookieString.length; i++) {

		if (cookieString[i].indexOf("products_") > -1) {
			var temp = cookieString[i].replace("products_", "")
			var interger = temp.split("=")[0];
			intArr.push(interger);
		}
	}
}


// thêm sản phẩm vào giỏ hàng
$(document).on("click", ".add-cart", function (ev) {
	var current = ev.currentTarget;

	var idadd = current.getAttribute('data-id');
	setCookie('products_' + idadd, idadd, 200);
	split();
	getcart();
	//AddCart(ThucDon, Price, Img)
})



// xóa cookies đễ xóa sản phẩm trong giỏ hàng
$(document).on("click", ".delete", function (ev) {
	var data = ev.target;
	var id = data.getAttribute("data-id")
	setCookie("products_" + id, 0, -1);
	getcart();
	totalprice();
})
// mở và đóng cái giỏ hàng
const cartbtn = document.querySelector(".fa-times")
const cartShow = document.querySelector(".fa-cart-plus")
cartShow.addEventListener("click", function () {
	document.querySelector(".card").style.right = "0"
})
cartbtn.addEventListener("click", function () {
	document.querySelector(".card").style.right = "-100%"
})

$(document).on("click", "#buy", () => {
	const soluong = document.querySelectorAll(".input");
	const allCookie = document.cookie;
	const cookieArray = allCookie.split(';');
	var j = 0;
	for (var i = 0; i < cookieArray.length; i++) {
		if (cookieArray[i].indexOf("products_") != -1) {
			var id = parseInt(cookieArray[i].replace("products_", "").split("=")[0].trim())
			setCookie("products_" + id, parseInt(soluong[j].value))
			j++;
		}
	};
})

window.addEventListener("load", () => {
	getcart();
})
// get cái id trên cookies tìm trong db để xuất ra màn hình
function getcart() {
	const allCookie = document.cookie;
	const cookieArray = allCookie.split(';');
	var newArrayCookie = [];
	for (var i = 0; i < cookieArray.length; i++) {
		if (cookieArray[i].indexOf("products_") != -1) {
			newArrayCookie.push(parseInt(cookieArray[i].replace("products_", "").split("=")[0].trim()));
		}
	};
	if (newArrayCookie.length == 0) {
		const tbody = document.querySelector("#cart-body");
		tbody.innerHTML = ""
		totalprice()
	}
	else {
		$.post('/tab/cart', { idList: newArrayCookie }, function (data, a, b) {
			if (data.length > 0) {
				const tbody = document.querySelector("#cart-body");
				tbody.innerHTML = "";
				console.log(tbody);
				for (var i = 0; i < data.length; i++) {
					const { giaTien, thucDon, hinh, duongdan, id } = data[i];
					var html = `<tr>
						<td style="display: flex; align-items: center;"><img style="width:70px" src="/img/menu/${duongdan}" alt=""><p class="menu-cart ml-1">${thucDon}</p></td>
						<td> <p><span class="abc">${giaTien}</span><sup>đ</sup></p></td>
						<td><input class="input" style="width:30px;outline:none;" type="number" value="1" min="1"></td>
						<td data-id="${id}" class="delete" style="cursor: pointer;">Xóa</td>
					</tr>`;
					tbody.insertAdjacentHTML('beforeend', html);
				}
			}
			inputchange()
			totalprice()
		});
	}
}
// tính tổng số tiền trên giao diện
function totalprice() {
	var price = document.querySelectorAll("tbody tr")
	var tong = 0;
	var dem = 0;
	if (price.length != 0) {
		for (var i = 0; i < price.length; i++) {
			var gia = price[i].querySelector(".abc").innerHTML;
			var soluong = price[i].querySelector("input").value;
			tong = tong + (gia * soluong)
			dem++;
		}
	}
	else {
		tong = 0;
    }
	var total = document.querySelector(".price-total span")
	var demp = document.querySelector(".navbar-nav sup")
	demp.innerHTML = dem;
	total.innerHTML = tong
}
// sự kiện thay đổi số lượng sản phẩm để thay đổi lại tổng số tiền
function inputchange() {
	var cartitem = document.querySelectorAll("tbody tr")
	for (var i = 0; i < cartitem.length; i++) {
		var input = cartitem[i].querySelector(".input")
		input.addEventListener("change", function (ev) {
			totalprice()
		})		
	}
}