﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PortalEntities : DbContext
    {
        public PortalEntities()
            : base("name=PortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BinhLuan> BinhLuans { get; set; }
        public DbSet<KhachSan> KhachSans { get; set; }
        public DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<PhieuGiaoDich> PhieuGiaoDiches { get; set; }
        public DbSet<ThanhToan> ThanhToans { get; set; }
        public DbSet<UuDai> UuDais { get; set; }
        public DbSet<Vung> Vungs { get; set; }
    
        public virtual ObjectResult<sp_DanhSachGiaoDich_Result> sp_DanhSachGiaoDich()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DanhSachGiaoDich_Result>("sp_DanhSachGiaoDich");
        }
    
        public virtual ObjectResult<usp_BaoCaoDoanhThu_Result> usp_BaoCaoDoanhThu(Nullable<int> thangbaocao, Nullable<int> nambaocao)
        {
            var thangbaocaoParameter = thangbaocao.HasValue ?
                new ObjectParameter("thangbaocao", thangbaocao) :
                new ObjectParameter("thangbaocao", typeof(int));
    
            var nambaocaoParameter = nambaocao.HasValue ?
                new ObjectParameter("nambaocao", nambaocao) :
                new ObjectParameter("nambaocao", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BaoCaoDoanhThu_Result>("usp_BaoCaoDoanhThu", thangbaocaoParameter, nambaocaoParameter);
        }
    
        public virtual int usp_BinhLuanKS(string idKS, string binhLuan, string tieuDe, Nullable<System.DateTime> thoiGianBL, Nullable<int> danhGia, string hoTen, string email)
        {
            var idKSParameter = idKS != null ?
                new ObjectParameter("idKS", idKS) :
                new ObjectParameter("idKS", typeof(string));
    
            var binhLuanParameter = binhLuan != null ?
                new ObjectParameter("binhLuan", binhLuan) :
                new ObjectParameter("binhLuan", typeof(string));
    
            var tieuDeParameter = tieuDe != null ?
                new ObjectParameter("tieuDe", tieuDe) :
                new ObjectParameter("tieuDe", typeof(string));
    
            var thoiGianBLParameter = thoiGianBL.HasValue ?
                new ObjectParameter("thoiGianBL", thoiGianBL) :
                new ObjectParameter("thoiGianBL", typeof(System.DateTime));
    
            var danhGiaParameter = danhGia.HasValue ?
                new ObjectParameter("danhGia", danhGia) :
                new ObjectParameter("danhGia", typeof(int));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BinhLuanKS", idKSParameter, binhLuanParameter, tieuDeParameter, thoiGianBLParameter, danhGiaParameter, hoTenParameter, emailParameter);
        }
    
        public virtual int usp_capNhatThongTinNguoiDung(string idNguoiDung, string eMail, string userName, string passWord, string hoTen, string diaChi, string dienThoai, Nullable<int> loaiND, Nullable<int> tinhTrang, Nullable<int> diemTong)
        {
            var idNguoiDungParameter = idNguoiDung != null ?
                new ObjectParameter("IdNguoiDung", idNguoiDung) :
                new ObjectParameter("IdNguoiDung", typeof(string));
    
            var eMailParameter = eMail != null ?
                new ObjectParameter("eMail", eMail) :
                new ObjectParameter("eMail", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("diaChi", diaChi) :
                new ObjectParameter("diaChi", typeof(string));
    
            var dienThoaiParameter = dienThoai != null ?
                new ObjectParameter("dienThoai", dienThoai) :
                new ObjectParameter("dienThoai", typeof(string));
    
            var loaiNDParameter = loaiND.HasValue ?
                new ObjectParameter("loaiND", loaiND) :
                new ObjectParameter("loaiND", typeof(int));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("tinhTrang", tinhTrang) :
                new ObjectParameter("tinhTrang", typeof(int));
    
            var diemTongParameter = diemTong.HasValue ?
                new ObjectParameter("diemTong", diemTong) :
                new ObjectParameter("diemTong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_capNhatThongTinNguoiDung", idNguoiDungParameter, eMailParameter, userNameParameter, passWordParameter, hoTenParameter, diaChiParameter, dienThoaiParameter, loaiNDParameter, tinhTrangParameter, diemTongParameter);
        }
    
        public virtual int usp_CapNhatUuDai(Nullable<int> mauudai, string tenuudai, Nullable<int> tinhtrang)
        {
            var mauudaiParameter = mauudai.HasValue ?
                new ObjectParameter("mauudai", mauudai) :
                new ObjectParameter("mauudai", typeof(int));
    
            var tenuudaiParameter = tenuudai != null ?
                new ObjectParameter("tenuudai", tenuudai) :
                new ObjectParameter("tenuudai", typeof(string));
    
            var tinhtrangParameter = tinhtrang.HasValue ?
                new ObjectParameter("tinhtrang", tinhtrang) :
                new ObjectParameter("tinhtrang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CapNhatUuDai", mauudaiParameter, tenuudaiParameter, tinhtrangParameter);
        }
    
        public virtual int USP_DANGKY(string idNguoiDung, string eMail, string userName, string passWord, string hoTen, string diaChi, string dienThoai, Nullable<int> loaiND, Nullable<int> tinhTrang, Nullable<int> diemTong)
        {
            var idNguoiDungParameter = idNguoiDung != null ?
                new ObjectParameter("IdNguoiDung", idNguoiDung) :
                new ObjectParameter("IdNguoiDung", typeof(string));
    
            var eMailParameter = eMail != null ?
                new ObjectParameter("eMail", eMail) :
                new ObjectParameter("eMail", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("diaChi", diaChi) :
                new ObjectParameter("diaChi", typeof(string));
    
            var dienThoaiParameter = dienThoai != null ?
                new ObjectParameter("dienThoai", dienThoai) :
                new ObjectParameter("dienThoai", typeof(string));
    
            var loaiNDParameter = loaiND.HasValue ?
                new ObjectParameter("loaiND", loaiND) :
                new ObjectParameter("loaiND", typeof(int));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("tinhTrang", tinhTrang) :
                new ObjectParameter("tinhTrang", typeof(int));
    
            var diemTongParameter = diemTong.HasValue ?
                new ObjectParameter("diemTong", diemTong) :
                new ObjectParameter("diemTong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DANGKY", idNguoiDungParameter, eMailParameter, userNameParameter, passWordParameter, hoTenParameter, diaChiParameter, dienThoaiParameter, loaiNDParameter, tinhTrangParameter, diemTongParameter);
        }
    
        public virtual int usp_DanhGiaKhachSan(string idNguoiDung, Nullable<int> idKS, Nullable<int> danhGia)
        {
            var idNguoiDungParameter = idNguoiDung != null ?
                new ObjectParameter("IdNguoiDung", idNguoiDung) :
                new ObjectParameter("IdNguoiDung", typeof(string));
    
            var idKSParameter = idKS.HasValue ?
                new ObjectParameter("idKS", idKS) :
                new ObjectParameter("idKS", typeof(int));
    
            var danhGiaParameter = danhGia.HasValue ?
                new ObjectParameter("danhGia", danhGia) :
                new ObjectParameter("danhGia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DanhGiaKhachSan", idNguoiDungParameter, idKSParameter, danhGiaParameter);
        }
    
        public virtual ObjectResult<usp_LayDSKhachSan_Result> usp_LayDSKhachSan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_LayDSKhachSan_Result>("usp_LayDSKhachSan");
        }
    
        public virtual int usp_ThemKhachSan(string id, string url, Nullable<int> idvung, string tinhtrang, Nullable<int> loaiks, Nullable<double> diemdgia)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            var idvungParameter = idvung.HasValue ?
                new ObjectParameter("idvung", idvung) :
                new ObjectParameter("idvung", typeof(int));
    
            var tinhtrangParameter = tinhtrang != null ?
                new ObjectParameter("tinhtrang", tinhtrang) :
                new ObjectParameter("tinhtrang", typeof(string));
    
            var loaiksParameter = loaiks.HasValue ?
                new ObjectParameter("loaiks", loaiks) :
                new ObjectParameter("loaiks", typeof(int));
    
            var diemdgiaParameter = diemdgia.HasValue ?
                new ObjectParameter("diemdgia", diemdgia) :
                new ObjectParameter("diemdgia", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ThemKhachSan", idParameter, urlParameter, idvungParameter, tinhtrangParameter, loaiksParameter, diemdgiaParameter);
        }
    
        public virtual int usp_ThemPhieuGiaoDich(Nullable<double> tongTien, Nullable<System.DateTime> ngayLapPhieu, Nullable<int> tinhTrang, Nullable<System.DateTime> ngayNhanPhong, Nullable<System.DateTime> ngayTraPhong, Nullable<int> soLuongPhong, string ghiChu, string loaiPhong, string idNguoiDP, string idKS, Nullable<int> hinhThucThanhToan)
        {
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("tongTien", tongTien) :
                new ObjectParameter("tongTien", typeof(double));
    
            var ngayLapPhieuParameter = ngayLapPhieu.HasValue ?
                new ObjectParameter("ngayLapPhieu", ngayLapPhieu) :
                new ObjectParameter("ngayLapPhieu", typeof(System.DateTime));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("tinhTrang", tinhTrang) :
                new ObjectParameter("tinhTrang", typeof(int));
    
            var ngayNhanPhongParameter = ngayNhanPhong.HasValue ?
                new ObjectParameter("ngayNhanPhong", ngayNhanPhong) :
                new ObjectParameter("ngayNhanPhong", typeof(System.DateTime));
    
            var ngayTraPhongParameter = ngayTraPhong.HasValue ?
                new ObjectParameter("ngayTraPhong", ngayTraPhong) :
                new ObjectParameter("ngayTraPhong", typeof(System.DateTime));
    
            var soLuongPhongParameter = soLuongPhong.HasValue ?
                new ObjectParameter("soLuongPhong", soLuongPhong) :
                new ObjectParameter("soLuongPhong", typeof(int));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("ghiChu", ghiChu) :
                new ObjectParameter("ghiChu", typeof(string));
    
            var loaiPhongParameter = loaiPhong != null ?
                new ObjectParameter("loaiPhong", loaiPhong) :
                new ObjectParameter("loaiPhong", typeof(string));
    
            var idNguoiDPParameter = idNguoiDP != null ?
                new ObjectParameter("idNguoiDP", idNguoiDP) :
                new ObjectParameter("idNguoiDP", typeof(string));
    
            var idKSParameter = idKS != null ?
                new ObjectParameter("idKS", idKS) :
                new ObjectParameter("idKS", typeof(string));
    
            var hinhThucThanhToanParameter = hinhThucThanhToan.HasValue ?
                new ObjectParameter("hinhThucThanhToan", hinhThucThanhToan) :
                new ObjectParameter("hinhThucThanhToan", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ThemPhieuGiaoDich", tongTienParameter, ngayLapPhieuParameter, tinhTrangParameter, ngayNhanPhongParameter, ngayTraPhongParameter, soLuongPhongParameter, ghiChuParameter, loaiPhongParameter, idNguoiDPParameter, idKSParameter, hinhThucThanhToanParameter);
        }
    
        public virtual int usp_ThemPhieuGiaoDichKhachViengTham(Nullable<double> tongTien, Nullable<System.DateTime> ngayLapPhieu, Nullable<int> tinhTrang, Nullable<System.DateTime> ngayNhanPhong, Nullable<System.DateTime> ngayTraPhong, Nullable<int> soLuongPhong, string ghiChu, string loaiPhong, string idKS, Nullable<int> hinhThucThanhToan, string hoten, string email, string diachi, string dienthoai)
        {
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("tongTien", tongTien) :
                new ObjectParameter("tongTien", typeof(double));
    
            var ngayLapPhieuParameter = ngayLapPhieu.HasValue ?
                new ObjectParameter("ngayLapPhieu", ngayLapPhieu) :
                new ObjectParameter("ngayLapPhieu", typeof(System.DateTime));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("tinhTrang", tinhTrang) :
                new ObjectParameter("tinhTrang", typeof(int));
    
            var ngayNhanPhongParameter = ngayNhanPhong.HasValue ?
                new ObjectParameter("ngayNhanPhong", ngayNhanPhong) :
                new ObjectParameter("ngayNhanPhong", typeof(System.DateTime));
    
            var ngayTraPhongParameter = ngayTraPhong.HasValue ?
                new ObjectParameter("ngayTraPhong", ngayTraPhong) :
                new ObjectParameter("ngayTraPhong", typeof(System.DateTime));
    
            var soLuongPhongParameter = soLuongPhong.HasValue ?
                new ObjectParameter("soLuongPhong", soLuongPhong) :
                new ObjectParameter("soLuongPhong", typeof(int));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("ghiChu", ghiChu) :
                new ObjectParameter("ghiChu", typeof(string));
    
            var loaiPhongParameter = loaiPhong != null ?
                new ObjectParameter("loaiPhong", loaiPhong) :
                new ObjectParameter("loaiPhong", typeof(string));
    
            var idKSParameter = idKS != null ?
                new ObjectParameter("idKS", idKS) :
                new ObjectParameter("idKS", typeof(string));
    
            var hinhThucThanhToanParameter = hinhThucThanhToan.HasValue ?
                new ObjectParameter("hinhThucThanhToan", hinhThucThanhToan) :
                new ObjectParameter("hinhThucThanhToan", typeof(int));
    
            var hotenParameter = hoten != null ?
                new ObjectParameter("hoten", hoten) :
                new ObjectParameter("hoten", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var dienthoaiParameter = dienthoai != null ?
                new ObjectParameter("dienthoai", dienthoai) :
                new ObjectParameter("dienthoai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ThemPhieuGiaoDichKhachViengTham", tongTienParameter, ngayLapPhieuParameter, tinhTrangParameter, ngayNhanPhongParameter, ngayTraPhongParameter, soLuongPhongParameter, ghiChuParameter, loaiPhongParameter, idKSParameter, hinhThucThanhToanParameter, hotenParameter, emailParameter, diachiParameter, dienthoaiParameter);
        }
    
        public virtual int usp_ThemUuDai(string tenuudai)
        {
            var tenuudaiParameter = tenuudai != null ?
                new ObjectParameter("tenuudai", tenuudai) :
                new ObjectParameter("tenuudai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ThemUuDai", tenuudaiParameter);
        }
    
        public virtual ObjectResult<usp_XemUuDai_Result> usp_XemUuDai()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_XemUuDai_Result>("usp_XemUuDai");
        }
    
        public virtual int usp_XoaKhachSan(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_XoaKhachSan", idParameter);
        }
    
        public virtual int usp_XoaUuDai(Nullable<int> mauudai)
        {
            var mauudaiParameter = mauudai.HasValue ?
                new ObjectParameter("mauudai", mauudai) :
                new ObjectParameter("mauudai", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_XoaUuDai", mauudaiParameter);
        }
    }
}
