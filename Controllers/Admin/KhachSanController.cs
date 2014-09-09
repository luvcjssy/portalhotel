using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC08_SHBS.Models;

namespace EC08_SHBS.Controllers.Admin
{
    [Authorize(Roles="Admin")]
    public class KhachSanController : Controller
    {
        //
        // GET: /KhachSan/
        PortalEntities db = new PortalEntities();
        public ActionResult Index()
        {
            //var khachSan = db.usp_LayDSKhachSan();//bên này db.chấm cái j thì qua bên view . chấm đó
            //return View(khachSan);//còn thiếu tình trạng kìa ma ne có thuoc tinh gi phai lay ra het ak
            ViewBag.vung = db.Vungs.ToList();
            var khachsan = db.KhachSans.ToList();
            return View(khachsan);
        }
        [HttpPost]
        public ActionResult Index(string id, FormCollection collection)
        {
            int idVung = int.Parse(Request["tenVung"]);
            var khachSan = db.KhachSans.Where(c => c.idVung == idVung).ToList();
            return View(khachSan);
        }
        //Thêm khách sạn
        public ActionResult Create()
        {
            ViewBag.Vung = db.Vungs.ToList();
            var khachsan = new KhachSan();
            return View(khachsan);
        }

        [HttpPost]
        public ActionResult Create(KhachSan khachsan)
        {
            if (ModelState.IsValid)
            {
                string lastID = GetLastID_KS();
                string nextID = GetNextID("KS", "KhachSan", lastID, 8);
                khachsan.idKS = nextID;
                string tinhTrang = Request["nameTinhTrang"];
                db.usp_ThemKhachSan(khachsan.idKS,khachsan.URL,khachsan.idVung,tinhTrang,khachsan.loaiKS,khachsan.diemDanhGia);
                return RedirectToAction("index", "khachsan");
            }
            return View();
        }

        //Xoa khach san
        public ActionResult Delete(string id)
        {
            var khachsan = db.KhachSans.First(c => c.idKS== id);
            return View(khachsan);
        }

        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            db.usp_XoaKhachSan(id);
            return RedirectToAction("index", "khachsan");
        }


        public string GetLastID_KS()
        {
            //var q = db.NguoiDungs.OrderByDescending(x => x.IdNguoiDung
            List<KhachSan> listks = null;
            string result = null;
            listks = db.KhachSans.OrderByDescending(x => x.idKS).ToList();
            if (listks.Count != 0)
            {
                result = listks[0].idKS.ToString();
            }
            return result;
        }
        public string GetNextID(string KtVietTat, string nameTable, string MaCuoi, int lenght)
        {
            if (MaCuoi == "" || MaCuoi == null)
            {
                MaCuoi = KtVietTat + new string('0', lenght);
            }
            int maTiepTheo = int.Parse(MaCuoi.Remove(0, KtVietTat.Length)) + 1;
            string n = "";
            for (int i = 1; i <= lenght; i++)
            {
                if (maTiepTheo < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lenght - i; i++)
                    {
                        n = n + "0";
                    }
                    return KtVietTat + n + maTiepTheo.ToString();
                }
            }
            return KtVietTat + maTiepTheo;
        }

            
    }
}
