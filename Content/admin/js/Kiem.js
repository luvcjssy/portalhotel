function kiemTraTrong() {
    var thang = document.getElementById("idThang");
    var nam = document.getElementById("nm");
    

    if (thang.value == "0") {
        alert("Bạn chưa chọn tháng.");
        hoTen.focus();
        return false;
    }
    if (nam.value == "0") {
        alert("Bạn chưa chọn năm.");
        diaChi.focus();
        return false;
    }
    
}

function kiemTraThang() {
    var vung = document.getElementById("tg");
    if (vung.value == "0") {
        alert("Chưa chọn thành phố");
        vung.focus();
        return false;
    }
}