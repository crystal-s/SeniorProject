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

        public ActionResult Login()
        {
            ViewBag.Title = "Log In!";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Title = "Create a New Account!";

            return View();
        }
    }
}