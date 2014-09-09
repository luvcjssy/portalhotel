function kiemTraBinhLuan() {
    var hoTen = document.getElementById("txt_hoten");
    var eMail = document.getElementById("txt_email");
    var tieuDe = document.getElementById("txt_tieude");
    var noiDung = document.getElementById("TextArea1");
    if (hoTen == null)
    {
        if (tieuDe.value == "") {
            alert("Tiêu đề không được bỏ trống.");
            tieuDe.focus();
            return false;
        }

        if (noiDung.value == "") {
            alert("Nội dung không được bỏ trống.");
            noiDung.focus();
            return false;
        }
    }
    else
    {
        if (hoTen.value == "") {
            alert("Họ tên không được bỏ trống.");
            hoTen.focus();
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

        if (tieuDe.value == "") {
            alert("Tiêu đề không được bỏ trống.");
            tieuDe.focus();
            return false;
        }

        if (noiDung.value == "") {
            alert("Nội dung không được bỏ trống.");
            noiDung.focus();
            return false;
        }
    }

}