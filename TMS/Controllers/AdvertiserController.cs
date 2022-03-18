using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.Models.Database;
using TMS.Models.Database.Entity;

namespace TMS.Controllers
{
    public class AdvertiserController : Controller
    {
        // GET: Advertiser
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View(new AdvertiserinfoModel());
        }
        [HttpPost]
        public ActionResult Register(AdvertiserinfoModel AD)
        {
            if (ModelState.IsValid)
            {
                ADEntities db = new ADEntities();
                var a = new AdvertiserinfoModel();

                var n = new AdvertiserInfo();

                n.advertiserid = AD.advertiserid;
                n.emailid = AD.emailid;
                n.username = AD.username;
                n.password = AD.password;

                db.AdvertiserInfoes.Add(n);
                db.SaveChanges();   
            }
            return View(AD);
        }

    }
}