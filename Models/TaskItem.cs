// /Models/TaskItem.cs
namespace MyTodoApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }  // Primary Key (SQLite will automatically handle this)
        public string Title { get; set; }  // Task title
        public string Description { get; set; }  // Task description
        public string Category { get; set; }  // Category for organizing tasks
        public bool IsCompleted { get; set; }  // Task status (completed or not)
        public DateTime CreatedAt { get; set; }  // Timestamp of when the task was created
    }
}
