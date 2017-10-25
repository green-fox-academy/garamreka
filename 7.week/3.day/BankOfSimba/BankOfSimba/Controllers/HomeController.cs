using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        [Route("simba")]
        public IActionResult Simba()
        {
            var bankAccount = new BankAccount("Simba", 2000.00, "lion", true, true);
            return View(bankAccount);
        }

        [Route("list")]
        public IActionResult List()
        {
            var bankAccount = new BankAccount();

            bankAccount.clients.Add(new BankAccount("Simba", 2000.00, "lion", true, true));
            bankAccount.clients.Add(new BankAccount("Timon", 1000.00, "meerkat", false, false));
            bankAccount.clients.Add(new BankAccount("Pumbaa", 1000.00, "warthog", false, false));
            bankAccount.clients.Add(new BankAccount("Mafiki", 500.00, "mandrill", false, true));
            bankAccount.clients.Add(new BankAccount("Zazu", 500.00, " red-billed hornbill", false, true));

            return View(bankAccount);
        }
    }
}
