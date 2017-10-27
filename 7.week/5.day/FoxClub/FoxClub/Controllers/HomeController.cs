using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet]
        [Route ("index")]
        public IActionResult Index()
        {
            var fox = new Fox()
            {
                Name = "Mr. Fox",
                Food = Food.Pizza,
                Drink = Drink.Lemonade,
                
            };

            return View(fox);
        }

        [HttpGet]
        [Route("nutritionStore")]
        public IActionResult NutritionStore()
        {
            return View(fox);
        }

        [HttpPost]
        [Route("nutritionStore")]
        public IActionResult ChangeNutrition()
        {
            return RedirectToAction("NutritionStore");
        }

        //[HttpPost]
        //[Route("trickCenter")]
        //public IActionResult PostTrickCenter()
        //{
        //    return RedirectToAction("TrickCenter");
        //}

        [HttpGet]
        [Route("trickCenter")]
        public IActionResult TrickCenter()
        {
            return View();
        }
    }
}
