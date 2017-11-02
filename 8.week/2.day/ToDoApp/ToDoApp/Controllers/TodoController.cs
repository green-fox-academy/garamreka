using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Repositories;

namespace ToDoApp.Controllers
{
    [Route ("/todo")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
           TodoRepository = todoRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetTodo());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Todo todo)
        {
            TodoRepository.AddTodo(todo);
            return RedirectToAction("List");
        }

        [HttpPost]
        [Route("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            TodoRepository.DeleteTodo(id);
            return RedirectToAction("List");
        }

        [HttpPost]
        [Route("/todo/{id}/edit")]
        public IActionResult Edit(int id)
        {
            var todo = TodoRepository.GetID(id);
            return View(todo);
        }

        [HttpPost]
        [Route("/{id}/update")]
        public IActionResult Update(Todo todo)
        {
            TodoRepository.UpdateTodo(todo);
            return RedirectToAction("List");
        }
    }
}
