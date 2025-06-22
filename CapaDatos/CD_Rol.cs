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
    public class CD_Rol
    {
        // Funcion que permite listar todos los usuarios
        public List<Rol> Listar()
        {
            // Se crea una referencia a la lista, la cual se inicializa como lista vacia
            List<Rol> roles = new List<Rol>();

            // Se emplea la conexion definida previamente, esto es posible por la clase conexion creada en Conexion.cs
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Se realiza una consulta con la tabla Users por los datos que se pretenden obtener
                    string query = "Select id_rol, nombre, activo from rol";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Rol()
                            {
                                Id_Rol = Convert.ToInt32(reader["id_rol"]),
                                Nombre = reader["nombre"].ToString(),
                                Activo = Convert.ToInt32(reader["activo"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    roles = new List<Rol>();
                }
            }

            return roles;
        }

        // Método para obtener los roles del usuario que ha inciado sesion
        public List<Rol> Permisos(int id_users)
        {
            List<Rol> permisosUsuario = new List<Rol>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Consulta hecha en tabla usuario - roles
                    string query = @"SELECT rol.id_rol, rol.nombre, rol.activo 
                        FROM rol rol
                        INNER JOIN [usuario] usuario ON usuario.id_rol = rol.id_rol
                        WHERE usuario.id_rol = @id_rol";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id_rol", id_users);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permisosUsuario.Add(new Rol()
                            {
                                Id_Rol = Convert.ToInt32(reader["id_rol"]),
                                Nombre = reader["nombre"].ToString(),
                                Activo = Convert.ToInt32(reader["activo"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    permisosUsuario = new List<Rol>();
                }
            }

            return permisosUsuario;
        }
    }
}
