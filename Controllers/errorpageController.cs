using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC08_SHBS.Controllers
{
    public class errorpageController : Controller
    {
        //400 Bad File Request
        public ActionResult e400()
        {
            return View();
        }

        //401 Unauthorized
        public ActionResult e401()
        {
            return View();
        }

        //403 Forbidden/Access Denied
        public ActionResult e403()
        {
            return View();
        }

        // 404 File Not Found
        public ActionResult e404()
        {
            return View();
        }

        //408 Request Timeout
        public ActionResult e408()
        {
            return View();
        }

        //500 Internal Error
        public ActionResult e500()
        {
            return View();
        }

        //501 Not Implemented
        public ActionResult e501()
        {
            return View();
        }

        //502 Service Temporarily Overloaded
        public ActionResult e502()
        {
            return View();
        }

        //503 Service Unavailable
        public ActionResult e503()
        {
            return View();
        }

    }
}
