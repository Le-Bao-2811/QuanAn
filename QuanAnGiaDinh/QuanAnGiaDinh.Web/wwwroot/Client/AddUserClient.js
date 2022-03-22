$(document).on('click', '.signup', (ev) => {
    ev.preventDefault();
    var data = $('#form-signup').serialize();
    $.post('/userclient/_signup', data, (data,textStatus,jqXHR) => {
        if (data == true) {
			if (data == true) {
				Swal.fire(
					'Tạo tài khoản thành công',
					'Ấn ok tiếp tục!',
					'success'
				).then(() => {
					window.location.href = "/home/index"
				})
			}
			else {
				alert("Thất bại");
			}
        }
    })
})