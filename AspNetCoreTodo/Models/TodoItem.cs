using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        [Required]
        public string? Title { get; set; }
        [Required]
        public DateTimeOffset DueAt { get; set; }

        public string UserId { get; set; }

        public TodoItem()
        {
            // default due date is 3 days from now
            DueAt = DateTimeOffset.Now.AddDays(3);
        }
    }

}