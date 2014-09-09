using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC08_SHBS.Models;

namespace EC08_SHBS.Controllers.Admin
{
    [Authorize(Roles="Admin")]
    public class adminController : Controller
    {
        //
        // GET: /admin/
        PortalEntities db = new PortalEntities();
        public ActionResult index()
        {
            return View();
        }
        //danh sach giao dich
        public ActionResult DSGiaoDich()
        {
            var ds = db.sp_DanhSachGiaoDich();
            return View(ds);
        }

    }
}
