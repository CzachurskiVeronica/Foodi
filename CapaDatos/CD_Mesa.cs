using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Mesa
    {
        // Función que permite listar todos los menús
        public List<Mesa> Listar()
        {
            List<Mesa> listas = new List<Mesa>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Consulta SQL para obtener los menús
                    string query = @"SELECT id_mesa, cap_personas_max, ocupado, activo FROM Mesa";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Se crea un nuevo objeto Menu y se asignan los valores leídos
                            listas.Add(new Mesa()
                            {
                                Id_Mesa = Convert.ToInt32(reader["id_mesa"]),
                                Cap_Personas_Max = Convert.ToInt32(reader["cap_personas_max"]),
                                Ocupado = Convert.ToInt32(reader["ocupado"]),
                                Activo = Convert.ToInt32(reader["activo"]),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    listas = new List<Mesa>();
                }
            }

            return listas;
        }

        // Función que permite registrar un nuevo menú
        public int RegistrarMesa(Mesa mesa, out string Mensaje)
        {
            int idMesa = 0;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para registrar el menú
                    SqlCommand cmd = new SqlCommand("SP_REGISTROMESA", conexion);
                    cmd.Parameters.AddWithValue("cap_personas_max", mesa.Cap_Personas_Max);
                    cmd.Parameters.AddWithValue("ocupado", mesa.Ocupado);
                    cmd.Parameters.AddWithValue("activo", mesa.Activo);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idMesa = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idMesa = 0;
                Mensaje = ex.Message;
            }
            return idMesa;
        }

        // Función que permite editar un menú existente
        public bool EditarMesa(Mesa mesa, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para editar el menú
                    SqlCommand cmd = new SqlCommand("SP_EDITARMESA", conexion);
                    cmd.Parameters.AddWithValue("id_mesa", mesa.Id_Mesa);
                    cmd.Parameters.AddWithValue("cap_personas_max", mesa.Cap_Personas_Max);
                    cmd.Parameters.AddWithValue("ocupado", mesa.Ocupado);
                    cmd.Parameters.AddWithValue("activo", mesa.Activo);

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
        public bool EliminarMesa(Mesa mesa, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para eliminar el menú
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARMESA", conexion);
                    cmd.Parameters.AddWithValue("id_mesa", mesa.Id_Mesa);

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
