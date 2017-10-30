using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        Greeting greeting;

        public HomeController(Greeting greeting)
        {
            this.greeting = greeting;
        }

        [HttpGet]
        [Route ("")]
        public IActionResult Index()
        {
            return View(greeting);
        }

        [HttpPost]
        [Route ("")]
        public IActionResult Post(Greeting greeting)
        {
            return RedirectToAction("Greet", greeting);
        }

        [HttpGet]
        [Route ("greet")]
        public IActionResult Greet(Greeting greeting)
        {
            return View(greeting);
        }
    }
}
