using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Permisos
{
    public class PermisosRolAttribute: ActionFilterAttribute
    {
        private int idRol;

        public PermisosRolAttribute(int _idRol)
        {
            this.idRol = _idRol;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["usuario"] != null)
            {
                UsuarioLoginDto usuario = HttpContext.Current.Session["usuario"] as UsuarioLoginDto;

                if(usuario.rol != this.idRol)
                {
                    filterContext.Result = new RedirectResult("~/Home/SinPermiso");
                }
            }
        }
    }
}