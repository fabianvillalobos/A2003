using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IAuthRepostitory
    {
        int NuevoUsuario(usuarios usuario);
        usuarios EncontrarUsuario(string email, string contrasena);
    }
}
