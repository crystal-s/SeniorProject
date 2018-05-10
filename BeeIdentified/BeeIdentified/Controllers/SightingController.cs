using BeeIdentified.Models;
using System.Linq;
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

    }
}