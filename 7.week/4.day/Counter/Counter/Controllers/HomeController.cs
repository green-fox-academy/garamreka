using Microsoft.AspNetCore.Mvc;
using CounterApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route ("index")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost]
        [Route ("index")]
        public IActionResult IncreaseCounter()
        {
            counter.Raise();
            return RedirectToAction("Index");
        }
    }
}
