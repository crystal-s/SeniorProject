using BeeIdentified.Data.Entities;
using BeeIdentified.Models;
//using BeeIdentified.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace BeeIdentified.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
       // private readonly EntityRespository _repo;
        //public UserController(EntityRespository repo)
        //{
        //    _repo = repo;
        //}


        // GET: User
        [Authorize]
        public ActionResult History()
        {
            ViewBag.Title = "User History";
            var UserBeeInfo = context.UserBees;
            
            // ALMOST works
            //var userHisotryInfo = (from BD in context.BeeDatas
            //           join UB in context.UserBees on BD.BeeID equals UB.BeeID
            //           select new {
            //               UB.UserID,
            //               UB.Location,
            //               UB.BeeID,
            //               BD. CommonName }).ToList();
            
            //var count = 0;
            //foreach (var Loc in info)
            //{
            //    count++; // each UNIQUE Location in collection
            //}

            return View(UserBeeInfo);
        }

        [Authorize]
        public ActionResult UserBeeList()   // Explicit list of bee names based on ID for user
        {
            ViewBag.Title = "User History";

            var UserBeeInfo = context.UserBees.ToList();

            return View(UserBeeInfo);
        }

        //[Authorize]
        //[HttpPost]
        //public ActionResult Create(UserBees userBeeInfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _repo.SaveUserBee(userBeeInfo);
        //    }

        //    return RedirectToAction("History", new { UserId = userBeeInfo.UserID });
        //}
        
    }
}