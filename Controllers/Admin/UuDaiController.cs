using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC08_SHBS.Models;

namespace EC08_SHBS.Controllers.Admin
{
    [Authorize(Roles="Admin")]
    public class UuDaiController : Controller
    {
        //
        // GET: /UuDai/
        PortalEntities db = new PortalEntities();
        public ActionResult Index()
        {
            var uudai = db.UuDais.ToList();
            return View(uudai);
        }

        // thêm ưu đãi
        public ActionResult Create()
        {
            var uudai = new UuDai();
            return View(uudai);
        }

        [HttpPost]
        public ActionResult Create(UuDai udai)
        {
            if (ModelState.IsValid)
            {
                db.usp_ThemUuDai(udai.tenUuDai);
                return RedirectToAction("index", "uudai");
            }
            return View(udai);
        }

        // xóa ưu đãi
        public ActionResult Delete(int id)
        {
            var udai = db.UuDais.First(c => c.idUuDai == id);
            return View(udai);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            //db.usp_XoaUuDai(id);
            var uudai = db.UuDais.First(c => c.idUuDai == id);
            db.UuDais.Remove(uudai);
            db.SaveChanges();
            return RedirectToAction("index", "uudai");
        }

        //cập nhật ưu đãi
        public ActionResult Edit(int id)
        {
            var udai = db.UuDais.First(c => c.idUuDai == id);
            return View(udai);
        }

        [HttpPost]
        public ActionResult Edit(int id, string ten,int tinhtrang)
        {
            var udai = db.UuDais.First(c => c.idUuDai == id);
            if (TryUpdateModel(udai))
            {
                db.usp_CapNhatUuDai(udai.idUuDai,udai.tenUuDai,udai.tinhTrang);
                return RedirectToAction("index", "uudai");
            }
            return View(udai);
        }
    }
}
