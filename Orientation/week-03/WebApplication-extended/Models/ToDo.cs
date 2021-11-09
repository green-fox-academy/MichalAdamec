using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ToDo
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public Assignee Assignee { get; set; }
        public long AssigneeId { get; set; }
    }
}
