


	window.addEventListener('load', () => {
		callData();
	});

	const callData = () => {
		var url = '/Tab/MenuClient';
		axios.get(url).then(response => {
			let data = response.data;
			console.log(data.length)
			appenddatatotable(data);
		});
	}
const body = document.querySelector("#menu-body")
console.log(body)
	const appenddatatotable = (data) => {
		for (var i = 0; i < data.length; i++) {
			let { thucDon, giaTien, duongdan,id } = data[i]
			var html = `
			<div class="col-lg-3 col-md-6">
				<div class="team-item">
					<div class="team-img">
						<img src="/img/menu/${duongdan}" width="50" height="230"  alt="Image">
						<div class="team-social">
							<a href=""><i class="fab fa-twitter"></i></a>
							<a href=""><i class="fab fa-facebook-f"></i></a>
							<a href=""><i class="fab fa-linkedin-in"></i></a>
							<a href=""><i class="fab fa-instagram"></i></a>
						</div>
					</div>
					<div class="team-text">
						<h2>${thucDon}</h2>
						<p>${giaTien}</p>
					</div>
					<div class="pl-5">
						<a style="color:black" data-id="${id}" class="btn btn-danger add-cart">Thêm vào giỏ hàng</a>
					</div>
				</div>
			</div>
			`;
		body.insertAdjacentHTML("beforeend", html)
		}
	
	}

