using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{
    public class ListOfAssignees
    {
        public Assignee Assignee { get; set; }

        public List<Assignee> AssigneeS { get; set; }
    }
}
