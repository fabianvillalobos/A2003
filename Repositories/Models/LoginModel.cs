using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class LoginModel
    {
        public string email { get; set; }
        public bool estado { get; set; }
        public string contrasena { get; set; }
    }
}
