﻿using System.Web.Mvc;

namespace BeeIdentified.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [Authorize]
        public ActionResult History()
        {
            ViewBag.Title = "User History";
            return View();
        }

        [Authorize]
        public ActionResult UserBeeList()
        {
            ViewBag.Title = "User History";
            return View();
        }
    }
}