using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using Microsoft.AspNetCore.Http;

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
        [Route ("information")]
        public IActionResult Information()
        {
            var fox = new Fox()
            {
                Name = "Mr. Fox",
                Food = Food.Pizza,
                Drink = Drink.Lemonade
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
            //fox.Food = 
            //fox.Drink = 
            return RedirectToAction("Information");
        }

        //[HttpPost]
        //[Route("trickCenter")]
        //public IActionResult LearnNewTrick()
        //{
        //    return RedirectToAction("Information");
        //}

        [HttpGet]
        [Route("trickCenter")]
        public IActionResult TrickCenter()
        {
            return View(fox);
        }
    }
}
