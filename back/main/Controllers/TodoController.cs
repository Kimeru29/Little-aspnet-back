
using System;
using System.Collections.Generic;
using main.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace main.Controllers
{
  [Route("api")]
  [EnableCors("MyPolicy")]
  public class TodoController : Controller
  {
    public List<TodoItem> Todos { get; set; }
    public TodoController()
    {
      Todos = new List<TodoItem>()
      {
          new TodoItem()
          {
              Id = new Guid(),
              IsDone = true,
              Title = "Título 1",
              DueAt = null
          },
          new TodoItem()
          {
              Id = new Guid(),
              IsDone = false,
              Title = "Título 2",
              DueAt = null
          },
          new TodoItem()
          {
              Id = new Guid(),
              IsDone = false,
              Title = "Título 3",
              DueAt = null
          }
      };
    }

    [HttpGet]
    public IList<TodoItem> Get() => Todos;
  }
}
