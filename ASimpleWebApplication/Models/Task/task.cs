using ASimpleWebApplication.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASimpleWebApplication.Models.Task
{
    public class task
    {
        [Key]
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public virtual user u { get; set; }
    }
}