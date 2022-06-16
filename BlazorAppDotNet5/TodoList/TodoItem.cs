using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDotNet5.TodoList
{
    public class TodoItem
    {
        public string? title { get; set; }
        public DateTime? dueDate { get; set; }
        public bool isDone { get; set; }
    }
}
