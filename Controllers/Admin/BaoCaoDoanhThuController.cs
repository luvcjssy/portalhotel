using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC08_SHBS.Models;


namespace EC08_SHBS.Controllers.Admin
{
    [Authorize(Roles="Admin")]
    public class BaoCaoDoanhThuController : Controller
    {
        //
        // GET: /BaoCaoDoanhThu/
        PortalEntities db = new PortalEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string nameThang, string nam)
        {

            int iThang = int.Parse(nameThang);
            int iNam = int.Parse(nam);

            if (iThang != 0 && iNam != 0)
            {
                var dt = db.usp_BaoCaoDoanhThu(iThang, iNam);
                return View(dt);
            }
            else
            {
                ModelState.AddModelError("", "");
            }
            return View();
        }

    }
}
