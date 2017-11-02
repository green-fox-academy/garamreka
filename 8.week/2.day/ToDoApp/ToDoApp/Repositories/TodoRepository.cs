﻿using System.Collections.Generic;
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

        public void AddTodo(Todo todo)
        {
            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            var todo = TodoContext.Todos.FirstOrDefault(t => t.Id == id);

            TodoContext.Todos.Remove(todo);
            TodoContext.SaveChanges();
        }
    }
}
