using System.ComponentModel.DataAnnotations;

namespace TodoList_ASP.NET_MVC.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsCompleted { get; set; }
    }
}
