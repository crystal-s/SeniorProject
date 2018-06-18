using System.Web.Mvc;

namespace BeeIdentified.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome Home!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "What is IdentiBee?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact the Developer";

            return View();
        }

        public ActionResult LegalNotice()
        {
            ViewBag.Title = "Legal Notice";

            return View();
        }

        public ActionResult PhotoCredit()
        {
            ViewBag.Title = "Photo Credit";

            return View();
        }
    }
}