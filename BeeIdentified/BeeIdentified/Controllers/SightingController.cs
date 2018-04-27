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
            return View();
        }

    }
}