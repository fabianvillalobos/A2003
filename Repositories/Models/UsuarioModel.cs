using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string pNombre { get; set; }
        public string sNombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public DateTime creado { get; set; }
        public bool estado { get; set; }
        public string direccion { get; set; }
        public string comuna { get; set; }
        public string region { get; set; }
    }
}
