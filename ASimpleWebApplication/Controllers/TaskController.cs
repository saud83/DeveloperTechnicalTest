using ASimpleWebApplication.Data;
using ASimpleWebApplication.Models.Task;
using ASimpleWebApplication.ViewModel.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASimpleWebApplication.Controllers
{
    public class TaskController : Controller
    {
        private ASimpleWebApplicationContext _context;
        public TaskController()
        {
            _context = new ASimpleWebApplicationContext();
        }
        // GET: Task
        public ActionResult Dashboard()
        {
            var taskList = _context.tasks.ToList();
            List<TaskViewModel> taskViewList = taskList.Select(sourceItem => new TaskViewModel
            {
                TaskId = sourceItem.TaskId,
                UserId = sourceItem.UserId,
                Description = sourceItem.Description,
                IsCompleted = sourceItem.IsCompleted
            }).ToList();
            return View(taskViewList);
        }
        [HttpPost]
        public ActionResult Dashboard(int taskId, string newDescription)
        {
            var task = _context.tasks.Where(t => t.TaskId == taskId).FirstOrDefault();
            if(task != null)
            {
                task.Description = newDescription;
                _context.SaveChanges();
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}