using Microsoft.AspNetCore.Mvc;
using Todolist.Models;
using Todolist.Services;

namespace Todolist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var todos = await _todoService.GetAllTodos();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoById(int id)
        {
            var todo = await _todoService.GetTodoById(id);
            if (todo == null)
                return NotFound();
            return Ok(todo);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] TodoItem item)
        {
            var addedTodo = await _todoService.AddTodo(item);
            return CreatedAtAction(nameof(GetTodoById), new { id = addedTodo.Id }, addedTodo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodo(int id, [FromBody] TodoItem item)
        {
            if (id != item.Id)
                return BadRequest();

            var updatedTodo = await _todoService.UpdateTodo(item);
            return Ok(updatedTodo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            var result = await _todoService.DeleteTodo(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }

}
