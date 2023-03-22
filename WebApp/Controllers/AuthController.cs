using Services.Class;
using Services.Dtos;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApp.Permisos;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController()
        {
            _authService = new AuthService();
        }

        [PermisosRol(1)]
        public ActionResult Logon(FormCollection model)
        {
            if (ModelState.IsValid && model.Count > 0)
            {
                //Guardar
                
                int mensajeGuardar = _authService.NuevoUsuario(model["pNombre"].ToString(), model["sNombre"].ToString(), model["apPaterno"].ToString(),
                    model["apMaterno"].ToString(), model["email"].ToString(), model["contrasena"].ToString(), model["direccion"].ToString(), model["comuna"].ToString(),
                    model["region"].ToString());
                if(mensajeGuardar != 0)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        public ActionResult Login(FormCollection model) 
        {
            if (ModelState.IsValid && model.Count > 0)
            {
                UsuarioLoginDto salida = _authService.EncontrarUsuario(model["email"].ToString(), model["contrasena"].ToString());
                if (salida.email != null)
                {
                    FormsAuthentication.SetAuthCookie(model["email"].ToString(), false);
                    Session["usuario"] = salida;
                    return RedirectToAction("Index", "Home");
                }

                return View();
            }
            return View();   
        }

        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            Session["usuario"] = null;
            return RedirectToAction("Login", "Auth");
        }
    }
}