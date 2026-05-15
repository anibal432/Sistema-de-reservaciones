using System.Configuration;
using System.Data.SqlClient;

namespace SistemaReservaciones
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager
                .ConnectionStrings["Conexion"].ConnectionString;
            return new SqlConnection(cadena);
        }
    }
}
