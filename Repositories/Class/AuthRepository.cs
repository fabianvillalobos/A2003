using Dapper;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Class
{
    public class AuthRepository: IAuthRepostitory
    {
        public int NuevoUsuario(usuarios usuario)
        {
            int salida = 0;

            try
            {
                using (A2003Entities database = new A2003Entities())
                {
                    database.usuarios.Add(usuario);
                    database.SaveChanges();
                    return salida = 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return salida;
            }
        }

        public usuarios EncontrarUsuario(string email, string contrasena)
        {
            usuarios user = new usuarios();
            try
            {

                using (A2003Entities database = new A2003Entities())
                {
                    user = database.usuarios.Where(a => a.email == email).FirstOrDefault();
                }
                var passDesEncriptara = DesEncriptar(user.contrasena);

                if (contrasena == passDesEncriptara)
                {
                    return user;
                }
                return new usuarios();
            }
            catch (Exception ex)
            {
                Console.WriteLine("EncontrarUsuario", ex.Message);
                return new usuarios();
            }
        }

        public static string DesEncriptar(string contrasena)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(contrasena);
            result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
