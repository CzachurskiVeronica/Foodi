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
    public class CD_Pago
    {
        // Función que permite listar todos los menús
        public List<Pago> Listar()
        {
            List<Pago> listas = new List<Pago>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Consulta SQL para obtener los menús
                    string query = @"SELECT Id_Pago, nombre, activo FROM Pago";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Se crea un nuevo objeto Pago y se asignan los valores leídos
                            listas.Add(new Pago()
                            {
                                Id_pago = Convert.ToInt32(reader["Id_Pago"]),
                                Nombre = reader["nombre"].ToString(),
                                Activo = Convert.ToInt32(reader["activo"]),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    listas = new List<Pago>();
                }
            }

            return listas;
        }

        // Función que permite registrar un nuevo menú
        public int RegistrarPago(Pago Pago, out string Mensaje)
        {
            int idPago = 0;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para registrar el menú
                    SqlCommand cmd = new SqlCommand("SP_REGISTROPAGO", conexion);
                    cmd.Parameters.AddWithValue("id_Pago", Pago.Id_pago);
                    cmd.Parameters.AddWithValue("nombre", Pago.Nombre);
                    cmd.Parameters.AddWithValue("activo", Pago.Activo);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idPago = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idPago = 0;
                Mensaje = ex.Message;
            }
            return idPago;
        }

        // Función que permite editar un menú existente
        public bool EditarPago(Pago Pago, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para editar el menú
                    SqlCommand cmd = new SqlCommand("SP_EDITARPAGO", conexion);
                    cmd.Parameters.AddWithValue("Id_Pago", Pago.Id_pago);
                    cmd.Parameters.AddWithValue("nombre", Pago.Nombre);
                    cmd.Parameters.AddWithValue("activo", Pago.Activo);

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
        public bool EliminarPago(Pago Pago, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Se define el comando SQL para eliminar el menú
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPAGO", conexion);
                    cmd.Parameters.AddWithValue("Id_Pago", Pago.Id_pago);

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
