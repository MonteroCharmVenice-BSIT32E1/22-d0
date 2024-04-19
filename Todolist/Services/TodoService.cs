using Todolist.DataAccess;
using Todolist.Models;

namespace Todolist.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TodoItem>> GetAllTodos()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TodoItem> GetTodoById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TodoItem> AddTodo(TodoItem item)
        {
            return await _repository.AddAsync(item);
        }

        public async Task<TodoItem> UpdateTodo(TodoItem item)
        {
            return await _repository.UpdateAsync(item);
        }

        public async Task<bool> DeleteTodo(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }

}
