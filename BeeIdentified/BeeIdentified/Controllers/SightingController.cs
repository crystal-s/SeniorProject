using BeeIdentified.Data.Entities;
using BeeIdentified.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
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

        [HttpPost]
        public ActionResult BasicInfo(string SeenLocation, string isFuzzy)
        {
            TempBeeBuilder BeeBuilder = new TempBeeBuilder();
            BeeBuilder.Fuzzy = isFuzzy;
            BeeBuilder.Location = SeenLocation;

            return RedirectToAction("Colors", "Sighting", BeeBuilder);
        }

        // To display the colors page
        public ActionResult Colors(TempBeeBuilder BeeBuilder)
        {
            return View(BeeBuilder);
        }

        // To navigate from the colors page
        [HttpPost]
        public ActionResult Colors(TempBeeBuilder BeeBuilder, string colorone, string colortwo, string colorthree)
        {
            if (colorone == "0" && colortwo == "0" && colorthree == "0")
            {
                // Let the user know they should enter some colors
                return RedirectToAction("Colors", "Sighting", BeeBuilder);
            }

            var firstcolor = (Color)Int32.Parse(colorone);
            var secondcolor = (Color)Int32.Parse(colortwo);
            var thirdcolor = (Color)Int32.Parse(colorthree);

            BeeBuilder.FirstColor = firstcolor;
            BeeBuilder.SecondColor = secondcolor;
            BeeBuilder.ThirdColor = thirdcolor;
            
            return RedirectToAction("PossibleMatches", "Sighting", BeeBuilder);
        }

        // To display 
        public ActionResult PossibleMatches(TempBeeBuilder BeeBuilder)
        {
            // Does fuzzy match? 
            // If at least one color matches, add it to the list to display
            // Also checks that we are not comparing empty fields

            var beeInfo = context.BeeDatas.ToList();
            // Guarantees unique data
            var beesToDisplay = new HashSet<BeeData>();
            foreach (var bee in beeInfo)
            {
                if ((bee.Fuzzy.ToString() == BeeBuilder.Fuzzy))
                {
                    if (bee.FirstColor.ToString() != "0" && ((bee.FirstColor == BeeBuilder.FirstColor) || (bee.FirstColor == BeeBuilder.SecondColor) || (bee.FirstColor == BeeBuilder.ThirdColor)))
                    {
                        beesToDisplay.Add(bee);
                    }
                    if (bee.SecondColor.ToString() != "0" && ((bee.SecondColor == BeeBuilder.FirstColor) || (bee.SecondColor == BeeBuilder.SecondColor) || (bee.SecondColor == BeeBuilder.ThirdColor)))
                    {
                        beesToDisplay.Add(bee);
                    }
                    if (bee.ThirdColor.ToString() != "0" && ((bee.ThirdColor == BeeBuilder.FirstColor) || (bee.ThirdColor == BeeBuilder.SecondColor) || (bee.ThirdColor == BeeBuilder.ThirdColor)))
                    {
                        beesToDisplay.Add(bee);
                    }
                }
            }
            return View(beesToDisplay);
        }

        [HttpPost]
        public ActionResult PossibleMatches(TempBeeBuilder BeeBuilder, string BeeId)
        {
            // Navigate to the CreateUserBee page --> eventually cut this out and go directly to the updated User History 
            BeeBuilder.BeeID = BeeId;

            return RedirectToAction("CreateUserBee", "Sighting", BeeBuilder);
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        public ActionResult CreateUserBee(TempBeeBuilder BeeBuilder)
        {
            var userbee = new UserBees();

            var ID = IdentityExtensions.GetUserId(HttpContext.User.Identity);
            userbee.BeeID = BeeBuilder.BeeID;
            userbee.Location = BeeBuilder.Location;
            userbee.UserID = ID;

            return View();
        }

        //[HttpPost]
        //public ActionResult CreateUserBee()
        //{

        //    // Navigate to the user history page
        //    return View();
        //}

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