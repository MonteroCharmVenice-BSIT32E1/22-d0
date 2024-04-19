using Todolist.Models;

namespace Todolist.DataAccess
{
    public interface ITodoRepository
    {
        Task<List<TodoItem>> GetAllAsync();
        Task<TodoItem> GetByIdAsync(int id);
        Task<TodoItem> AddAsync(TodoItem item);
        Task<TodoItem> UpdateAsync(TodoItem item);
        Task<bool> DeleteAsync(int id);
    }

}
