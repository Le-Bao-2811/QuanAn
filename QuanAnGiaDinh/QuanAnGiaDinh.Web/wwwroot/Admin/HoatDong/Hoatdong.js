$(document).ready(() => {
    $(document).on("click", ".xemdathang", (ev) => {
        var id = ev.currentTarget.getAttribute("data-id")
        var body = document.querySelector("#body");
        body.innerHTML = "";
        $.get("/admin/hoatdong/xemdathang/" + id, (res) => {
            $("#body").append(res);
           
        })
    })
})