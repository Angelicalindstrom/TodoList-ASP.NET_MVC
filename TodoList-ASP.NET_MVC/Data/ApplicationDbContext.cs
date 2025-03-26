using Microsoft.EntityFrameworkCore;
using TodoList_ASP.NET_MVC.Models;

namespace TodoList_ASP.NET_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
