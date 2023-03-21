using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAuthService
    {
        int NuevoUsuario(string pNombre, string sNombre, string apPaterno, string apMaterno, string email, string contrasena, string direccion, string comuna, string region);
    }
}
