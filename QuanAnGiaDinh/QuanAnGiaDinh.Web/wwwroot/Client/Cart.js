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

	var cart = document.querySelectorAll(".add-card")
	console.log(cart)
	var arrbtn = []
	for (var i = 0; i < cart.length; i++) {
		var btn = cart[i].getAttribute("data-id")
		arrbtn.push(btn)
	}
	// console.log(intArr.length);
	var a = [];
	for (var i = 0; i < intArr.length; i++) {
		//console.log("vbbbbbnbnbnbbbday la the i " +i+ " : "+intArr[i]);  
		for (var j = 0; j < arrbtn.length; j++) {
			if (intArr[i] === arrbtn[j]) {
				// console.log("Bang nhau "+ i+ j+ intArr[i]+arrbtn[j]) 
			}
			// console.log("day la the j " +j+ " : " +arrbtn[j]);                     
		}
	}


}



$(document).on("click", ".add-cart", function (ev) {
	var current = ev.currentTarget;

	var idadd = current.getAttribute('data-id');
	setCookie('products_' + idadd, idadd, 200);
	split();

	//AddCart(ThucDon, Price, Img)
})




$(document).on("click", ".delete", function (ev) {
	var taget = ev.target
	var parent = taget.parentElement;
	parent.remove()
	totalprice()
})

const cartbtn = document.querySelector(".fa-times")
console.log(cartbtn);
const cartShow = document.querySelector(".fa-cart-plus")
cartShow.addEventListener("click", function () {
	document.querySelector(".card").style.right = "0"
})
cartbtn.addEventListener("click", function () {
	document.querySelector(".card").style.right = "-100%"
})



$(document).on('click', '.show-cart', function () {
	const allCookie = document.cookie;
	const cookieArray = allCookie.split(';');
	var newArrayCookie = [];
	for (var i = 0; i < cookieArray.length; i++) {
		if (cookieArray[i].indexOf("products_") != -1) {
			newArrayCookie.push(parseInt(cookieArray[i].replace("products_", "").split("=")[0].trim()));
		}
	};
	
	$.post('/tab/cart', { idList: newArrayCookie }, function (data, a, b) {
		console.log(data);
		if (data.length > 0) {
			const tbody = document.querySelector("#cart-body");
			tbody.innerHTML = "";
			console.log(tbody);
			for (var i = 0; i < data.length; i++) {
				const { giaTien, thucDon, hinh, duongdan } = data[i];
				var html = `<tr>
						<td style="display: flex; align-items: center;"><img style="width:70px" src="/img/menu/${duongdan}" alt=""><p class="menu-cart">${thucDon}</p></td>
						<td> <p><span class="abc">${giaTien}</span><sup>đ</sup></p></td>
						<td><input class="input" style="width:30px;outline:none;" type="number" value="1" min="1"></td>
						<td style="cursor: pointer;">Xóa</td>
					</tr>`;
				tbody.insertAdjacentHTML('beforeend', html);
			}
		}
		inputchange()
		totalprice()
	});
	
})
function totalprice() {
	var price = document.querySelectorAll("tbody tr")
	var tong = 0;
	var dem = 0;
	for (var i = 0; i < price.length; i++) {
		var gia = price[i].querySelector(".abc").innerHTML;
		var soluong = price[i].querySelector("input").value;
		tong = tong + (gia * soluong)
		dem++;
	}
	var total = document.querySelector(".price-total span")
	var demp = document.querySelector(".navbar-nav sup")
	demp.innerHTML = dem;
	total.innerHTML = tong
}
function inputchange() {
	var cartitem = document.querySelectorAll("tbody tr")
	for (var i = 0; i < cartitem.length; i++) {
		var input = cartitem[i].querySelector(".input")
		input.addEventListener("change", function (ev) {
			totalprice()
		})		
	}
}