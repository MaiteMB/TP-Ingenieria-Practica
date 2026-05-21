using BE_Salem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Salem
{
    public class BitacoraDAL
    {
        public void RegistrarEvento(Bitacora_BE bitacora)
        {
            SqlConnection con = Conexion.ObtenerConexion();

            string query = "INSERT INTO Bitacora (IdUsuario, Usuario, Accion, Descripcion, FechaHora) " +
                           "VALUES (@idUsuario, @usuario, @accion, @descripcion, @fechaHora)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idUsuario", (object)bitacora.idUsuario ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@usuario", bitacora.usuario ?? "");
            cmd.Parameters.AddWithValue("@accion", bitacora.accion);
            cmd.Parameters.AddWithValue("@descripcion", bitacora.descripcion ?? "");
            cmd.Parameters.AddWithValue("@fechaHora", bitacora.fechaHora);

            try
            {
                Conexion.AbrirConexion(con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar en bitácora: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }
        }
    }
}
