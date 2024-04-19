using Todolist.Models;

namespace Todolist.Services
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetAllTodos();
        Task<TodoItem> GetTodoById(int id);
        Task<TodoItem> AddTodo(TodoItem item);
        Task<TodoItem> UpdateTodo(TodoItem item);
        Task<bool> DeleteTodo(int id);
    }

}
