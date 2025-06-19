using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Menu
    {
        // Función que permite listar todos los menús
        public List<Menu> Listar()
        {
            List<Menu> listas = new List<Menu>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Consulta SQL para obtener los menús
                    string query = @"SELECT id_menu, nombre, activo FROM Menu";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Se crea un nuevo objeto Menu y se asignan los valores leídos
                            listas.Add(new Menu()
                            {
                                Id_Menu = Convert.ToInt32(reader["id_menu"]),
                                Nombre = reader["nombre"].ToString(),
                                Activo = Convert.ToInt32(reader["activo"]),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    listas = new List<Menu>();
                }
            }

            return listas;
        }

        // Función que permite registrar un nuevo menú
        public int RegistrarMenu(Menu menu, out string Mensaje)
        {
            int idMenu = 0;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para registrar el menú
                    SqlCommand cmd = new SqlCommand("SP_REGISTROMENU", conexion);
                    cmd.Parameters.AddWithValue("id_menu", menu.Id_Menu);
                    cmd.Parameters.AddWithValue("nombre", menu.Nombre);
                    cmd.Parameters.AddWithValue("activo", menu.Activo);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idMenu = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idMenu = 0;
                Mensaje = ex.Message;
            }
            return idMenu;
        }

        // Función que permite editar un menú existente
        public bool EditarMenu(Menu menu, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para editar el menú
                    SqlCommand cmd = new SqlCommand("SP_EDITARMENU", conexion);
                    cmd.Parameters.AddWithValue("id_menu", menu.Id_Menu);
                    cmd.Parameters.AddWithValue("nombre", menu.Nombre);
                    cmd.Parameters.AddWithValue("activo", menu.Activo);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

        // Función que permite eliminar un menú
        public bool EliminarMenu(Menu menu, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para eliminar el menú
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARMENU", conexion);
                    cmd.Parameters.AddWithValue("id_menu", menu.Id_Menu);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}