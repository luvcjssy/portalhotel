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
    
    public partial class KhachSan
    {
        public KhachSan()
        {
            this.BinhLuans = new HashSet<BinhLuan>();
            this.PhieuGiaoDiches = new HashSet<PhieuGiaoDich>();
        }
    
        public string idKS { get; set; }
        public string URL { get; set; }
        public Nullable<int> idVung { get; set; }
        public string tinhTrang { get; set; }
        public Nullable<int> loaiKS { get; set; }
        public Nullable<double> diemDanhGia { get; set; }
    
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual Vung Vung { get; set; }
        public virtual ICollection<PhieuGiaoDich> PhieuGiaoDiches { get; set; }
    }
}