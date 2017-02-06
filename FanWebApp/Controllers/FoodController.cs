using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FanWebApp.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Coffee()
        {
            ViewBag.Title = "Coffee";
            return View();
        }

        public ActionResult Breakfast()
        {
            ViewBag.Title = "Breakfast Food";
            return View();
        }

        public ActionResult Sushi()
        {
            ViewBag.Title = "Sushi";
            return View();
        }
    }
}