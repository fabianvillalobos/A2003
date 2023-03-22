using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class UsuarioLoginDto
    {
        public string email { get; set; }
        public int rol { get; set; }
        public bool estado { get; set; }
    }
}
