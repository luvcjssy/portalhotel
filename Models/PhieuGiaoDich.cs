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
    
    public partial class PhieuGiaoDich
    {
        public int idPhieuGiaoDich { get; set; }
        public Nullable<double> tongTien { get; set; }
        public Nullable<System.DateTime> ngayLapPhieu { get; set; }
        public Nullable<int> tinhTrang { get; set; }
        public Nullable<System.DateTime> ngayNhanPhong { get; set; }
        public Nullable<System.DateTime> ngayTraPhong { get; set; }
        public Nullable<int> soLuongPhong { get; set; }
        public string ghiChu { get; set; }
        public string loaiPhong { get; set; }
        public string idNguoiDP { get; set; }
        public string idKS { get; set; }
        public Nullable<int> hinhThucThanhToan { get; set; }
    
        public virtual KhachSan KhachSan { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual ThanhToan ThanhToan { get; set; }
    }
}