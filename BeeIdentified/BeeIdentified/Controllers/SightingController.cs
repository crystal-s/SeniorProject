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

        public ActionResult Colors(TempBeeBuilder BeeBuilder)
        {
            return View(BeeBuilder);
        }

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

        public ActionResult NewSighting()
        {
            return View();
        }

        //public ActionResult Fuzzy()
        //{
        //    return View();
        //}

        public ActionResult PossibleMatches(TempBeeBuilder BeeBuilder)
        {
            // Find if the colors match
            // Does fuzzy match? 

            var beeInfo = context.BeeDatas.ToList();
            // Guarantees unique data
            var beesToDisplay = new HashSet<BeeData>();
            foreach (var bee in beeInfo)
            {
                if ((bee.Fuzzy.ToString() == BeeBuilder.Fuzzy))
                {
                    if ((bee.FirstColor == BeeBuilder.FirstColor) || (bee.FirstColor == BeeBuilder.SecondColor) || (bee.FirstColor == BeeBuilder.ThirdColor))
                    {
                        beesToDisplay.Add(bee);
                    }
                    if ((bee.SecondColor == BeeBuilder.FirstColor) || (bee.SecondColor == BeeBuilder.SecondColor) || (bee.SecondColor == BeeBuilder.ThirdColor))
                    {
                        beesToDisplay.Add(bee);
                    }
                    if ((bee.ThirdColor == BeeBuilder.FirstColor) || (bee.ThirdColor == BeeBuilder.SecondColor) || (bee.ThirdColor == BeeBuilder.ThirdColor))
                    {
                        beesToDisplay.Add(bee);
                    }
                }
            }
            return View(beesToDisplay);
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