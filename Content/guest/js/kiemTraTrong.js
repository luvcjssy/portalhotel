
function kiemTraTrong() {
    var hoTen = document.getElementById("hoTen");
    var diaChi = document.getElementById("diaChi");
    var dienThoai = document.getElementById("dienThoai");
    var eMail = document.getElementById("eMail");
    var passWord = document.getElementById("passWord");
    var passWord2 = document.getElementById("passWord2");

    if (hoTen.value == "") {
        alert("Họ tên không được bỏ trống.");
        hoTen.focus();
        return false;
    }
    if (diaChi.value == "") {
        alert("Địa chỉ không được bỏ trống.");
        diaChi.focus();
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

    if (passWord.value != "" && passWord.value.length < 6) {
        alert("Mật khẩu phải từ 6 kí tự trở lên.");
        passWord.focus();
        return false;
    }

    if (passWord2.value != passWord.value) {
        alert("Mật khẩu nhập lại không khớp.");
        passWord2.focus();
        return false;
    }
}