using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web.Mvc;
using Top15Cities.Models;
using System.Data.SqlClient;
using System.Data.Common;

namespace Top15Cities.Controllers
{
    public class HomeController : Controller
    {
        private Top15 db = new Top15();

        public ActionResult Index()
        {
            return View(db.Cities.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        public ActionResult WishList()
        {
            //Add the logic here that is going to add 
            //the logged in user and the selected city to db wishlist table

            ViewBag.Message = "Wish list of logged in user.";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
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
    }
}