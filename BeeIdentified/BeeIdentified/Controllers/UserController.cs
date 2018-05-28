using BeeIdentified.Data.Entities;
using BeeIdentified.Models;
//using BeeIdentified.Repositories;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;

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

            var ID = IdentityExtensions.GetUserId(HttpContext.User.Identity);
            var UserBeeInfo = context.UserBees.Where(u => u.UserID == ID.ToString());

            var beelist = CreateHistoryDisplay(UserBeeInfo.ToList());

            return View(beelist);
 
        }

        private List<HistoryDisplay> CreateHistoryDisplay(List<UserBees> thisUsersBees)
        {
            var historydisplays = new List<HistoryDisplay>();

           
            foreach (var bee in thisUsersBees)
            {
                var thisbee = context.BeeDatas.SingleOrDefault(m => m.BeeID == bee.BeeID);

                // location, name, number
                
                var history = new HistoryDisplay(bee.Location, thisbee.CommonName, 1);

                historydisplays.Add(history);
            }

            return historydisplays;
        }
        
    }
}