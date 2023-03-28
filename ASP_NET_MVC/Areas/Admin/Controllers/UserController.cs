using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC.Models;

namespace ASP_NET_MVC.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        QuanLyBanHoaEntities db = new QuanLyBanHoaEntities();
        public ActionResult Index()
        {
            var user = db.Nguoi_Dung.ToList();
            if (Session["id"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return View(user);
            }

        }

        [HttpGet]

        public ActionResult Delete(int id)
        {

            var user = db.Nguoi_Dung.Where(n => n.id == id).FirstOrDefault();
            return View(user);
        }
        [HttpPost]

        public ActionResult Delete(Nguoi_Dung userr)
        {
            var user = db.Nguoi_Dung.Where(n => n.id == userr.id).FirstOrDefault();
            db.Nguoi_Dung.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}