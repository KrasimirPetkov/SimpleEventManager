using SimpleEventManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace SimpleEventManager.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            var events = db.Events.OrderByDescending(evt => evt.StartDate).ThenByDescending(evt => evt.EndDate).ToPagedList(pageNumber, 6);

            return View(events);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Krasimir Petkov";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}