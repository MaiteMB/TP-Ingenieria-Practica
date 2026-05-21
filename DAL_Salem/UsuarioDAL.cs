using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Salem;

namespace DAL_Salem
{
    public class UsuarioDAL
    {
        public Usuario_BE ObtenerUsuarioPorUsername(string username)
        {
            Usuario_BE usuario = null;

            SqlConnection con = Conexion.ObtenerConexion();

            string query = "SELECT IdUsuario, Usuario, Nombre, Apellido, Clave, IdRol, " +
                           "Activo, Bloqueado, IntentosFallidos, FechaAlta " +
                           "FROM Usuario WHERE Usuario = @username";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                Conexion.AbrirConexion(con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario_BE();
                    usuario.idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    usuario.usuario = reader["Usuario"].ToString();
                    usuario.nombre = reader["Nombre"].ToString();
                    usuario.apellido = reader["Apellido"].ToString();
                    usuario.clave = reader["Clave"].ToString();
                    usuario.IdRol = Convert.ToInt32(reader["IdRol"]);
                    usuario.activo = Convert.ToBoolean(reader["Activo"]);
                    usuario.bloqueado = Convert.ToBoolean(reader["Bloqueado"]);
                    usuario.intentosFallidos = Convert.ToInt32(reader["IntentosFallidos"]);
                    usuario.fechaalta = Convert.ToDateTime(reader["FechaAlta"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuario: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }

            return usuario;
        }

        public void ActualizarIntentosFallidos(int idUsuario, int intentos)
        {
            SqlConnection con = Conexion.ObtenerConexion();

            string query = "UPDATE Usuario SET IntentosFallidos = @intentos WHERE IdUsuario = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@intentos", intentos);
            cmd.Parameters.AddWithValue("@id", idUsuario);

            try
            {
                Conexion.AbrirConexion(con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar intentos: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }
        }

        public void BloquearUsuario(int idUsuario)
        {
            SqlConnection con = Conexion.ObtenerConexion();

            string query = "UPDATE Usuario SET Bloqueado = 1, IntentosFallidos = 3 WHERE IdUsuario = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", idUsuario);

            try
            {
                Conexion.AbrirConexion(con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al bloquear usuario: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion(con);
            }
        }
    }
}
