using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieTable.Repositories;
using CalorieTable.Entities;
using CalorieTable.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieTable.Controllers
{
    public class HomeController : Controller
    {
        FoodRepository FoodRepository;

        public HomeController(FoodRepository foodRepository)
        {
            FoodRepository = foodRepository;
        }

        [HttpGet]
        [Route ("")]
        [Route("drax")]
        public IActionResult Drax()
        {
            return View(FoodRepository.GetAllFood());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddItem(Food food)
        {
            FoodRepository.AddFood(food);
            return RedirectToAction("Drax");
        }

        [HttpGet]
        [Route("/{Id}/edit")]
        public IActionResult Edit([FromQuery] string Id)
        {
            int id = int.Parse(Id);
            var food = FoodRepository.GetID(id);
            return View(food);
        }

        [HttpPost]
        [Route("/{Id}/edit")]
        public IActionResult ChangeAmount(Food food)
        {
            FoodRepository.ChangeAmount(food);
            return RedirectToAction("Drax");
        }

        [HttpPost]
        [Route("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            FoodRepository.Delete(id);
            return RedirectToAction("Drax");
        }

        [HttpGet]
        [Route ("/api")]
        public IActionResult GetFirstFood()
        {
            return Json(new { name = FoodRepository.GetFood().Name.ToString(), amount = FoodRepository.GetFood().Amount.ToString(), calorie = FoodRepository.GetFood().Calorie.ToString() });
        }

        [HttpGet]
        [Route("/nodatabase")]
        public IActionResult NoDatabase()
        {
            return Json(new { test = "Test endpoint without database" });
        }
    }
}
