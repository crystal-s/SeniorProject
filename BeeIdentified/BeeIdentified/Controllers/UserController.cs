using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeeIdentified.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult History()
        {
            ViewBag.Title = "User History";
            return View();
        }
        public ActionResult UserBeeList()
        {
            ViewBag.Title = "User History";
            return View();
        }
    }
}