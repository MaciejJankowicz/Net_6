using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zaj05.Models;

namespace zaj05.Controllers
{
    public class HomeController : Controller
    {
        private ConferenceUserContext db = new ConferenceUserContext();

        public ActionResult Index()
        {
            return View(new ConferenceUserViewModel());
        }

        [HttpPost]
        public ActionResult Index(ConferenceUserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                ConferenceUser cu = new ConferenceUser();
                UpdateModel(cu, "",null, new string[]{"Avatar"});
                if (vm.Avatar != null && vm.Avatar.ContentLength > 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        vm.Avatar.InputStream.CopyTo(memoryStream);
                        cu.Avatar = memoryStream.GetBuffer();
                    }
                }

                db.ConferenceUsers.AddOrUpdate(cu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

                return View(vm);
        }

        public ActionResult Display()
        {
            var model = db.ConferenceUsers.ToList();
            List < ConferenceUserDisplayViewModel > list = new List<ConferenceUserDisplayViewModel>();
            foreach (var item in model)
            {
                list.Add(new ConferenceUserDisplayViewModel { FirstName = item.FirstName,
                    LastName = item.LastName,
                    ConferenceType = item.ConferenceType,
                    Avatar = item.Avatar});
            }

            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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