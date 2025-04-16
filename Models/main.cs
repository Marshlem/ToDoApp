using System;
using MyTodoApp.Models;
using System.Linq;

namespace MyTodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TodoContext())
            {
                // Create a new TaskItem
                var newTask = new TaskItem
                {
                    Title = "Learn C#",
                    Description = "Complete the C# to-do list app",
                    Category = "Programming",
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                };

                // Add to the database and save changes
                db.Tasks.Add(newTask);
                db.SaveChanges();

                Console.WriteLine("Task added!");
            }
        }
    }
}
