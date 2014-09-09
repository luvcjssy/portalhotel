function kiemTraBooking() {
    var soPhong = document.getElementById("sophong");
    var hoTen = document.getElementById("fullname");
    var dienThoai = document.getElementById("phone");
    var eMail = document.getElementById("email");
    var diaChi = document.getElementById("diaChi");

    if (soPhong.value == "0") {
        alert("Chưa chọn số lượng phòng đặt.");
        soPhong.focus();
        return false;
    }

    if (hoTen.value == "") {
        alert("Họ tên không được bỏ trống.");
        hoTen.focus();
        return false;
    }
    
    if (dienThoai.value == "") {
        alert("Điện thoại không được bỏ trống.");
        dienThoai.focus();
        return false;
    }
    if (isNaN(dienThoai.value)) {
        alert("Điện thoại chỉ được nhập số.");
        dienThoai.focus();
        return false;
    }
    if (eMail.value == "") {
        alert("Email không được bỏ trống.");
        eMail.focus();
        return false;
    }
    var reg_mail = /^[A-Za-z0-9]+([_\.\-]?[A-Za-z0-9])*@[A-Za-z0-9]+([\.\-]?[A-Za-z0-9]+)*(\.[A-Za-z]+)+$/;
    if (reg_mail.test(eMail.value) == false) {
        alert("Email không hợp lệ.");
        eMail.focus();
        return false;
    }
    if (diaChi.value == "") {
        alert("Địa chỉ không được bỏ trống.");
        diaChi.focus();
        return false;
    }
}