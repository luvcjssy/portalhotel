using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC08_SHBS.Models
{
    public partial class NguoiDungModel
    {
        [Required(ErrorMessage = "Username không được bỏ trống")]
        [RegularExpression("[a-zA-Z0-9]*", ErrorMessage = "Username không được dùng kí tự đặc biệt")]
        [StringLength(150)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password không được bỏ trống")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password phải từ 6 - 20 kí tự")]
        public string Password { get; set; }
    }
}