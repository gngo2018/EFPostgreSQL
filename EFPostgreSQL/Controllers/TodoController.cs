using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoData.DataModel;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFPostgreSQLDemo.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        readonly TodoContext Context;

        public TodoController(TodoContext context)
            => Context = context;

        [HttpGet]
        public IActionResult GetTodos()
        {
            var todoList = Context.Todo.ToList();

            return Ok(todoList);
        }

        [HttpPost]
        public IActionResult CreateTodo()
        {
            var todo = new TodoDataModel()
            {
                TodoId = 1,
                Title = "Do Laundry",
                Body = @"You're laundry is looking bad..."
            };

            Context.Add(todo);
            Context.SaveChanges();

            return Ok("Successfully created a Todo");
        }
    }
}
