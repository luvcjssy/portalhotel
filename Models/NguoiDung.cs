//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC08_SHBS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            this.PhieuGiaoDiches = new HashSet<PhieuGiaoDich>();
        }
    
        public string IdNguoiDung { get; set; }
        public string eMail { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public Nullable<int> loaiND { get; set; }
        public Nullable<int> tinhTrang { get; set; }
        public Nullable<int> diemTong { get; set; }
    
        public virtual LoaiNguoiDung LoaiNguoiDung { get; set; }
        public virtual ICollection<PhieuGiaoDich> PhieuGiaoDiches { get; set; }
    }
}
