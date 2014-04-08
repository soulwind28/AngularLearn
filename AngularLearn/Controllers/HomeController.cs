using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularLearn.Models;

namespace AngularLearn.Controllers
{
    public class HomeController : Controller
    {
        private RedBack_DEVEntities db = new RedBack_DEVEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToDo()
        {
            return View();
        }

        public ActionResult Tutorial()
        {
            return View();
        }

        public ActionResult Tutorial2()
        {
            return View();
        }

        public ActionResult Tutorial3()
        {
            return View();
        }

        public ActionResult Step4()
        {
            return View();
        }

        public ActionResult Step5()
        {
            return View();
        }

        public JsonResult GetUsers()
        {
            var users = from u in db.Users
                        orderby u.FirstName, u.LastName
                        select new
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Username = u.Username
                        };

            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Step6()
        {
            var users = from u in db.Users
                        orderby u.FirstName, u.LastName
                        select new
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Username = u.Username
                        };

            ViewBag.Users = users;
            return View();
        }

        public ActionResult Step7()
        {
            return View();
        }

        public ActionResult PhoneList()
        {
            return View();
        }

        public ActionResult PhoneDetail()
        {
            return View();
        }

    }
}
