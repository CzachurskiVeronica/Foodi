using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ReporteVenta
    {
        public List<ReporteVentas> Ventas(string fechainicio, string fechafin, int id_users)
        {
            List<ReporteVentas> reporteVentas = new List<ReporteVentas>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    DateTime fechainicioFormatted = DateTime.Parse(fechainicio).Date;
                    DateTime fechafinFormatted = DateTime.Parse(fechafin).Date;

                    StringBuilder sql = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_REPORTEVENTAS", conexion);
                    cmd.Parameters.AddWithValue("fecha_inicio", fechainicioFormatted);
                    cmd.Parameters.AddWithValue("fecha_fin", fechafinFormatted);
                    cmd.Parameters.AddWithValue("id_users", id_users);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reporteVentas.Add(new ReporteVentas()
                            {
                                FechaVenta = reader["FechaVenta"].ToString(),
                                Nro_factura = reader["Nro_factura"].ToString(),
                                Importe_total = reader["Importe_total"].ToString(),
                                Vendedor = reader["Vendedor"].ToString(),
                                Codigo_producto = reader["Codigo_producto"].ToString(),
                                NombreProducto = reader["NombreProducto"].ToString(),
                                NombreCategoria = reader["NombreCategoria"].ToString(),
                                Precio = reader["Precio"].ToString(),
                                Subtotal = reader["Subtotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    reporteVentas = new List<ReporteVentas>();
                }
            }
            return reporteVentas;
        }
    }
}
