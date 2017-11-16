using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Arrow.Models;
using Arrow.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Arrow.Controllers
{
    public class HomeController : Controller
    {
        ArrowService ArrowService;

        public HomeController(ArrowService arrowService)
        {
            this.ArrowService = arrowService;
        }

        [HttpGet]
        [Route ("/yondu")]
        public IActionResult Yondu(double? distance, double? time)
        {
            return ArrowService.CheckIfNull(distance, time);
        }
    }
}
