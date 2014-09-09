using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC08_SHBS.Models;

namespace EC08_SHBS.Controllers.Admin
{
    public class ThanhVienController : Controller
    {
        PortalEntities db = new PortalEntities();
        //
        // GET: /thanhvien/

        public ActionResult nguoidung()
        {
            var nguoiDung = db.NguoiDungs.Where(x => x.loaiND == 1).ToList();
            return View(nguoiDung);
        }

        public ActionResult quantri()
        {
            var quanTri = db.NguoiDungs.Where(x => x.loaiND == 2).ToList();
            return View(quanTri);
        }

        public ActionResult delete(string id)
        {
            var thanhVien = db.NguoiDungs.First(c => c.IdNguoiDung == id);
            return View(thanhVien);
        }

        [HttpPost]
        public ActionResult delete(string id, FormCollection collection)
        {
            var thanhVien = db.NguoiDungs.First(c => c.IdNguoiDung == id);
            if (thanhVien.loaiND == 1)
            {
                db.NguoiDungs.Remove(thanhVien);
                db.SaveChanges();
                return RedirectToAction("nguoidung", "thanhvien");
            }
            else if (thanhVien.loaiND == 2)
            {
                db.NguoiDungs.Remove(thanhVien);
                db.SaveChanges();
                return RedirectToAction("quantri", "thanhvien");
            }
            return View();
        }

    }
}
