using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTpractice.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route ("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }
    }
}
