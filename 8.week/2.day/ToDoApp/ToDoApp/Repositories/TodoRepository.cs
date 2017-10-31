using System.Collections.Generic;
using System.Linq;
using ToDoApp.Entities;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetTodo()
        {
            return TodoContext.Todos.ToList();
        }
    }
}
