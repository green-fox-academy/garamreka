using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Arrow.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Arrow.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route ("/yondu")]
        public IActionResult Yondu(double? distance, double? time)
        {
            if (distance == null && time == null)
            {
                return NotFound();
            }
            else if (distance == null || time == null)
            {
                return Json(new ErrorMessage());
            }
            else
            {
                return Json(new Response() {Distance = distance, Time = time, Speed = distance * time });
            }
        }
    }
}
