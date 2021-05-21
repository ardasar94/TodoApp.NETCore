using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class TodoItemStatusDTO
    {
        public long Id { get; set; }

        public bool IsComplete { get; set; }
    }
}
