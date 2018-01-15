using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DbRelationMockPractice.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DbRelationMockPractice.Controllers
{
    public class HomeController : Controller
    {
        IPracticeRepository PracticeRepository;

        public HomeController(IPracticeRepository practiceRepository)
        {
            this.PracticeRepository = practiceRepository;
        }

        [Route ("/api/info")]
        public IActionResult Info()
        {
            return Json(PracticeRepository.GetEverything());
        }

        [Route("/api/change")]
        public IActionResult Change(string oldName, string newName)
        {
            return Json(PracticeRepository.ChangeName(oldName, newName));
        }

    }
}
