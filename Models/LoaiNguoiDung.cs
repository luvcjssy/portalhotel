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
    
    public partial class LoaiNguoiDung
    {
        public LoaiNguoiDung()
        {
            this.NguoiDungs = new HashSet<NguoiDung>();
        }
    
        public int idLoai { get; set; }
        public string tenLoai { get; set; }
    
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
