using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASimpleWebApplication.ViewModel.ProfileView
{
    public class ProfileViewModel
    {
        public int UserId { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}