using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC08_SHBS.Models
{
    
    public class NguoiDungInfo
    {
        public string IdNguoiDung { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string eMail { get; set; }

        [Required(ErrorMessage = "Username không được bỏ trống")]
        [RegularExpression("[a-zA-Z0-9]*", ErrorMessage = "Username không được dùng kí tự đặc biệt")]
        [StringLength(150)]
        public string userName { get; set; }

        [Required(ErrorMessage = "Password không được bỏ trống")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password phải từ 6 - 20 kí tự")]
        public string passWord { get; set; }

        [Required(ErrorMessage = "Họ tên không được bỏ trống")]
        public string hoTen { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được bỏ trống")]
        public string diaChi { get; set; }

        [Required(ErrorMessage = "Điện thoại không được bỏ trống")]
        [RegularExpression("[0-9]*", ErrorMessage = "Số điện thoại chỉ dùng số")]
        public string dienThoai { get; set; }

        public int loaiND { get; set; }
        
        public int tinhTrang { get; set; }
        
        public int diemTong { get; set; }
    }
}