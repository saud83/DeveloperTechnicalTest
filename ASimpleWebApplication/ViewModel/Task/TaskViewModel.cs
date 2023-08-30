using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASimpleWebApplication.ViewModel.Task
{
    public class TaskViewModel
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}