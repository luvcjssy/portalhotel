using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC08_SHBS.Models;

namespace EC08_SHBS.Controllers.Guest
{
    public class paypalController : Controller
    {
        //
        // GET: /paypal/

        public ActionResult ValidateCommand(string product, string totalPrice)
        {

            string thongTin = Request["soLuongPhong"] + " room(s) " + Request["bLoaiPhong"];
            string tongTien = Request["tongTien"];

            bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
            var paypal = new PaypalModel(useSandbox);

            paypal.item_name = thongTin;
            paypal.amount = tongTien;
            return View(paypal);
        }

        public ActionResult RedirectFromPaypal()
        {
            return View();
        }

        public ActionResult CancelFromPaypal()
        {
            return View();
        }

        public ActionResult NotifyFromPaypal()
        {
            return View();
        }


    }
}
