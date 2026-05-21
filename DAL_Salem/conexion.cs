using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Salem
{
    public class conexion
    { 
        private static string _cadena = "Data Source=Maite15\\MSSQLSERVER01;Initial Catalog=SalemCoffeeShop;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadena);
        }

        public static void AbrirConexion(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public static void CerrarConexion(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
