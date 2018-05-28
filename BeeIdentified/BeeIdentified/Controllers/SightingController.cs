using BeeIdentified.Data.Entities;
using BeeIdentified.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BeeIdentified.Controllers
{
    [Authorize]
    public class SightingController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
        
        // GET: Bee
        public ActionResult BasicInfo()
        {
            return View();
        }
        public ActionResult Colors()
        {
            return View();
        }
        public ActionResult NewSighting()
        {
            return View();
        }
        public ActionResult Fuzzy()
        {
            return View();
        }

        public ActionResult PossibleMatches()
        {
            var beeinfo = context.BeeDatas.ToList();
            
            return View(beeinfo);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateUserBee()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserBee(UserBees userBee)
        {
            if (ModelState.IsValid)
            {
                context.UserBees.Add(userBee);
                try
                {
                    await context.SaveChangesAsync();
                }
                /* Really need to change this to incriment instead of just throwing an exception when a user sees the same bee twice */
                catch (Exception ex)
                {
                    return RedirectToAction("CreateUserBee", "Sighting");
                }
                return RedirectToAction("History", "User");
            }
            return View(userBee);
        }

    }
}