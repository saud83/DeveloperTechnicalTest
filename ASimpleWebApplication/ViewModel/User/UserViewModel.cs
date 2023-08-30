using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASimpleWebApplication.ViewModel.User
{
    public class UserViewModel
    {
        [Display(Name = "User Name")]
        public string userName { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}