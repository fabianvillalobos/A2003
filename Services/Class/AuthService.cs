using Repositories.Class;
using Repositories.Interfaces;
using Repositories.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Class
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepostitory _authRepository;

        public AuthService()
        {
            _authRepository = new AuthRepository();
        }
        public int NuevoUsuario(string pNombre, string sNombre, string apPaterno, string apMaterno, string email, string contrasena, string direccion, string comuna, string region)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contrasena);

            UsuarioModel user = new UsuarioModel();
            user.pNombre = pNombre;
            user.sNombre = sNombre;
            user.apPaterno = apPaterno;
            user.apMaterno = apMaterno;
            user.email = email;
            user.contrasena = Convert.ToBase64String(encryted); ;
            user.estado = true;
            user.direccion = direccion;
            user.comuna = comuna;
            user.region = region;

            int resultado = _authRepository.NuevoUsuario(user);

            return resultado;
        }
    }
}
