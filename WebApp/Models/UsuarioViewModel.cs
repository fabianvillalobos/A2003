using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Display(Name = "Primer Nombre")]
        public string pNombre { get; set; }
        [MaxLength(50), Display(Name = "Segundo Nombre")]
        public string sNombre { get; set; }
        [MaxLength(50), Display(Name = "Apellido Paterno")]
        public string apPaterno { get; set; }
        [MaxLength(50), Display(Name = "Apellido Materno")]
        public string apMaterno { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"), Display(Name = "Email")]
        public string email { get; set; }
        [MinLength(6), MaxLength(12), Display(Name = "Constraseña")]
        public string contrasena { get; set; }
        [MaxLength(100), Display(Name = "Dirección")]
        public string direccion { get; set; }
        [MaxLength(40), Display(Name = "Comuna")]
        public string comuna { get; set; }
        [MaxLength(40), Display(Name = "Región")]
        public string region { get; set; }
    }
}