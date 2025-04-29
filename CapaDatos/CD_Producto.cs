using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Producto
    {
        // Listar todos los productos
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    string query = @"SELECT p.Id_Producto, p.Nombre, p.Descripción, p.Precio, 
                                            p.Activo, p.Stock, p.Stock_minimo, p.Activo,
                                            m.Id_Menu, m.Nombre AS NombreMenu
                                     FROM Producto p
                                     INNER JOIN Menu m ON p.Id_Menu = m.Id_Menu";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                Id_producto = Convert.ToInt32(reader["Id_Producto"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripción"] != DBNull.Value ? reader["Descripción"].ToString() : "",
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Stock = Convert.ToInt32(reader["Stock"]),
                                Stock_min = Convert.ToInt32(reader["Stock_minimo"]),
                                Menu = new Menu()
                                {
                                    Id_Menu = Convert.ToInt32(reader["Id_Menu"]),
                                    Nombre = reader["NombreMenu"].ToString(),
                                },
                                Activo = Convert.ToInt32(reader["Activo"]),

                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Producto>();
                }
            }

            return lista;
        }

        // Registrar un nuevo producto
        public int RegistrarProducto(Producto producto, out string Mensaje)
        {
            int idproducto = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTROPRODUCTOS", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("id_producto", producto.Id_producto);
                    cmd.Parameters.AddWithValue("Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", producto.Descripcion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("Activo", producto.Activo);
                    cmd.Parameters.AddWithValue("Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("Stock_minimo", producto.Stock_min);
                    cmd.Parameters.AddWithValue("Id_Menu", producto.Menu.Id_Menu);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idproducto = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idproducto = 0;
                Mensaje = ex.Message;
            }

            return idproducto;
        }

        // Editar producto existente
        public bool EditarProducto(Producto producto, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("Id_Producto", producto.Id_producto);
                    cmd.Parameters.AddWithValue("Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", producto.Descripcion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("Activo", producto.Activo);
                    cmd.Parameters.AddWithValue("Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("Stock_minimo", producto.Stock_min);
                    cmd.Parameters.AddWithValue("Id_Menu", producto.Menu.Id_Menu);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

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

        // Eliminar producto
        public bool EliminarProducto(Producto producto, out string Mensaje)
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
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", conexion);
                    cmd.Parameters.AddWithValue("Id_Producto", producto.Id_producto);

                    // Parametros de salida declarados en los procedimientos
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    // Salida desde el procedimiento almacenado para id producto y mensaje correspondiente predefinido
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
