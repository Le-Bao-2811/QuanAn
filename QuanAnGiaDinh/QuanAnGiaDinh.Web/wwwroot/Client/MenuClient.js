
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
				Swal.fire(
					'Đặt bàn thành công',
					'Ấn ok tiếp tục!',
					'success'
				).then(() => {
					window.location.href = "/home/index"
				})
			}
			else {
				alert("Thất bại");
			}
		},
		"json"
	);
});


