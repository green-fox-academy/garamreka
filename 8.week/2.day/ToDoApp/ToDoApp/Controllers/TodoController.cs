using Microsoft.AspNetCore.Mvc;
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

        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetTodo());
        }
    }
}
