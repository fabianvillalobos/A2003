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
        private readonly string conexion = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public int NuevoUsuario(UsuarioModel usuario)
        {
            int salida = 0;
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append("Insert Into dbo.usuarios Values( '");
                sb.Append(usuario.pNombre+"',"+"'"+usuario.sNombre+"','"+usuario.apPaterno+"','"+usuario.apMaterno+"','"+usuario.email+"',");
                sb.Append("'"+usuario.contrasena+"',GETDATE(),1,"+"'"+usuario.direccion+"','"+usuario.comuna+"','"+usuario.region+"');");
                sb.Append(" SELECT SCOPE_IDENTITY() ");

                string sql = sb.ToString();
                var conn = new SqlConnection(conexion);
                salida = conn.ExecuteScalar<int>(sql);
            }
            catch (Exception ex)
            {
                salida = 0;
                Console.WriteLine("NuevoUsuario " + ex.Message);
            }
            return salida;
        }
    }
}
