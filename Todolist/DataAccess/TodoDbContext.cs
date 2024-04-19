using Microsoft.EntityFrameworkCore;
using Todolist.Models;

namespace Todolist.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }
    }

}
