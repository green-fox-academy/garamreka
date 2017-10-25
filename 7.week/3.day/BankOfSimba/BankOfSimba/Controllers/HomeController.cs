using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        [Route("simba")]
        public IActionResult Index()
        {
            var bankAccount = new BankAccount("Simba", 2000.00, "lion");
            return View(bankAccount);
        }
    }
}
