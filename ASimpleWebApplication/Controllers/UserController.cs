using ASimpleWebApplication.Data;
using ASimpleWebApplication.Models.User;
using ASimpleWebApplication.ViewModel.ProfileView;
using ASimpleWebApplication.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASimpleWebApplication.Controllers
{
    public class UserController : Controller
    {
        private ASimpleWebApplicationContext _context;
        public UserController()
        {
            _context = new ASimpleWebApplicationContext();
        }
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel user)
        {
            var user_exist = _context.users.Where(u => u.UserName == user.userName && u.Password == user.password).FirstOrDefault();
            if(user_exist != null)
            {
                return RedirectToAction("Dashboard", "Task");
            }
            return View();
        }
        #pragma warning disable 
        public ActionResult Profile()
        {
            ProfileViewModel model = new ProfileViewModel 
            { 
                UserName = "MichelJordan_02",
            };
            return View(model);
        }
    }
}