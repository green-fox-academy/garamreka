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
        [Route ("")]
        public IActionResult Index()
        {
            return View(fox);
        }

        //[HttpPost]
        //[Route("nutritionStore")]
        //public IActionResult PostNutritionStore()
        //{
        //    return RedirectToAction("NutritionStore");
        //}

        [HttpGet]
        [Route("nutritionStore")]
        public IActionResult NutritionStore()
        {
            return View();
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
