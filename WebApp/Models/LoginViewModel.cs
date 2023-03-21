using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Contraseña")]
        public string contrasena { get; set; }
    }
}