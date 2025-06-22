using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Venta
    {
        // Para controlar la cantidad de los productos 
        public bool DisminuirStock(int id_producto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Se realiza una consulta con la tabla Venta por los datos que se pretenden obtener
                    string query = @"UPDATE Producto SET stock = stock - @cantidad WHERE id_producto = @id_producto";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool AcumularStock(int id_producto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    // Se realiza una consulta con la tabla Venta por los datos que se pretenden obtener
                    string query = @"UPDATE Producto SET stock = stock + @cantidad WHERE id_producto = @id_producto";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool RegistrarVenta(Pedido obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRODEVENTAS", conexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.Id_Usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("id_pago", obj.Id_Pago.Id_pago);
                    cmd.Parameters.AddWithValue("id_mesa", obj.Id_Mesa.Id_Mesa);
                    cmd.Parameters.AddWithValue("importe_total", obj.Total);
                    cmd.Parameters.Add(new SqlParameter("@DetalleVenta", SqlDbType.Structured)
                    {
                        TypeName = "dbo.EDetalle_Factura",
                        Value = DetalleCompra
                    });
                    // Parametros de salida declarados en los procedimientos
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    // Se define que tipo de comando es el que se esta ejecutando
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    // Salida desde el procedimiento almacenado para id usuario y mensaje correspondiente predefinido
                    Resultado = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Resultado = false;
                    Mensaje = ex.Message;
                }
            }

            return Resultado;
        }

    }
}
