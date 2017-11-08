using PmlMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PmlMvc.Controllers
{
    public class HomeController : Controller
    {
        private PmContext db = new PmContext();

        public ActionResult Index()
        {
            var model = db.ap_marchi.ToList();
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}