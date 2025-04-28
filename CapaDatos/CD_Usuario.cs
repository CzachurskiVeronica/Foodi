using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Security.Cryptography;

namespace CapaDatos
{
    public class CD_Usuario
    {
        // Funcion que permite listar todos los usuarios
        public List<Usuario> Listar()
        {
            // Se crea una referencia a la lista, la cual se inicializa como lista vacia
            List<Usuario> listas = new List<Usuario>();

            // Se emplea la conexion definida previamente, esto es posible por la clase conexion creada en Conexion.cs
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Se realiza una consulta con la tabla Usuarios por los datos que se pretenden obtener
                    string query = @"SELECT u.id_usuario, u.dni, u.nombre, u.apellido, 
                                     u.fecha_incorporación, u.contraseña, u.activo, rol.id_rol, rol.nombre AS RolName
                                     FROM Usuario u INNER JOIN Rol rol 
                                     ON Rol.id_rol = u.id_rol";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listas.Add(new Usuario()
                            {
                                Id_Usuario = Convert.ToInt32(reader["id_usuario"]),
                                DNI = Convert.ToInt32(reader["dni"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Contraseña = reader["contraseña"].ToString(),
                                Fecha_Incorporación = reader["fecha_incorporación"].ToString(),
                                Activo = Convert.ToInt32(reader["activo"]),
                                Id_rol = new Rol()
                                {
                                    Id_Rol = Convert.ToInt32(reader["Id_Rol"]),
                                    Nombre = reader["Nombre"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    listas = new List<Usuario>();
                }
            }

            return listas;
        }

        public int RegistrarUsuario(Usuario usuario, out string Mensaje)
        {
            // Inicializa las variables recibidas por parametro
            int idUser = 0;
            Mensaje = string.Empty;

            try
            {
                usuario.Contraseña = EncriptarPassword(usuario.Contraseña);

                // Se emplea la conexion definida previamente, esto es posible por la clase conexion creada en Conexion.cs
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Parametros de entrada de procedimiento almacenado creado en la base de datos
                    SqlCommand cmd = new SqlCommand("SP_REGISTROUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("id_rol", usuario.Id_rol);
                    cmd.Parameters.AddWithValue("dni", usuario.DNI);
                    cmd.Parameters.AddWithValue("nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("fecha_incorporacion", usuario.Fecha_Incorporación);
                    cmd.Parameters.AddWithValue("contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("activo", usuario.Activo);

                    // Parametros de salida declarados en los procedimientos
                    cmd.Parameters.Add("Usuario_creado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Respuesta", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    // Salida desde el procedimiento almacenado para id usuario y mensaje correspondiente predefinido
                    idUser = Convert.ToInt32(cmd.Parameters["Usuario_creado"].Value);
                    Mensaje = cmd.Parameters["Respuesta"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUser = 0;
                Mensaje = ex.Message;
            }
            return idUser;
        }

        // Método para encriptar la contraseña
        public string EncriptarPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Convertir a formato hexadecimal
                }
                return builder.ToString();
            }
        }

        public bool EditarUsuario(Usuario usuario, out string Mensaje)
        {
            // Inicializa las variables recibidas por parametro
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                usuario.Contraseña = EncriptarPassword(usuario.Contraseña);

                // Se emplea la conexion definida previamente, esto es posible por la clase conexion creada en Conexion.cs
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Parametros de entrada de procedimiento almacenado creado en la base de datos
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("id_usuario", usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("dni", usuario.DNI);
                    cmd.Parameters.AddWithValue("nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("fecha_incorporacion", usuario.Fecha_Incorporación);
                    cmd.Parameters.AddWithValue("contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("activo", usuario.Activo);
                    cmd.Parameters.AddWithValue("id_rol", usuario.Id_rol);

                    // Parametros de salida declarados en los procedimientos
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    // Salida desde el procedimiento almacenado para id usuario y mensaje correspondiente predefinido
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

        public bool EliminarUsuario(Usuario usuario, out string Mensaje)
        {
            // Inicializa las variables recibidas por parametro
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                // Se emplea la conexion definida previamente, esto es posible por la clase conexion creada en Conexion.cs
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    // Parametros de entrada de procedimiento almacenado creado en la base de datos
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("id_usuario", usuario.Id_Usuario);

                    // Parametros de salida declarados en los procedimientos
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    // Salida desde el procedimiento almacenado para id usuario y mensaje correspondiente predefinido
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
