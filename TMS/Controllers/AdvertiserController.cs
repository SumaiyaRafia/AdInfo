using AutoMapper;
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
            ADEntities db = new ADEntities();
            var ad = (from e in db.AdvertiserInfoes
                      where e.advertiserid.Equals(Session["id"])
                      select e).FirstOrDefault();

            var config = new MapperConfiguration(
            cfg => cfg.CreateMap<ADinfo, AdvertiserinfoADinfoModel>());
            var ads = ad.ADinfoes.ToList();
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
                Session["id"] = n.advertiserid.ToString();

                db.AdvertiserInfoes.Add(n);
                db.SaveChanges();
                return RedirectToAction("RegisterAD");
            }
            return View(AD);
        }
        public ActionResult RegisterAD()
        {
            return View(new ADinfoModel());
        }
        [HttpPost]
        public ActionResult RegisterAD(ADinfoModel AD)
        {
            if (ModelState.IsValid)
            {
                ADEntities db = new ADEntities();
                var a = new ADinfoModel();

                var n = new ADinfo();

                n.adid = AD.adid;
                n.advertisename = AD.advertisename;
                n.advertisebudget = AD.advertisebudget;
                n.contactno = AD.contactno;
                n.contactno = AD.contactno;
                n.advertiserid = AD.advertiserid;
                Session["id"] = n.advertiserid.ToString();

                db.ADinfoes.Add(n);
                db.SaveChanges();
            }
            return View(AD);
        }

    }
}