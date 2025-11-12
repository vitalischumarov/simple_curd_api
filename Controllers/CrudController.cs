using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using simple_crud.Model;

[Route("api/todo")]
[Controller]
public class CrudController : Controller
{
    List<TodoModel> todos = new List<TodoModel>
    {
        new TodoModel {Id = 1, Title = "ToDo no. 1", IsDone = false},
        new TodoModel {Id = 2, Title = "ToDo no. 2", IsDone = false},
        new TodoModel {Id = 3, Title = "ToDo no. 3", IsDone = true},
    };


    [HttpGet]
    public IActionResult getAllTodos()
    {
        var todoListAsJoson = JsonSerializer.Serialize(todos);
        return Ok($"{todoListAsJoson}");
    }

    [HttpGet("{id}")]
    public IActionResult getTodo(int id)
    {
        var todo = todos.FirstOrDefault(p => p.Id == id);
        if (todo != null)
        {
            return Ok($"Id: {todo.Id}, Name: {todo.Title}, IsDone: {todo.IsDone}");
        }
        else
        {
            return BadRequest("not found");
        }
    }
}
