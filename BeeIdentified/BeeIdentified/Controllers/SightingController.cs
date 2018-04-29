using BeeIdentified.Data.Entities;
using System.Web.Mvc;

namespace BeeIdentified.Controllers
{
    public class SightingController : Controller
    {
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
            // Give the view the information from the database
            //var BeeInfo = new 

            return View();
        }

    }
}