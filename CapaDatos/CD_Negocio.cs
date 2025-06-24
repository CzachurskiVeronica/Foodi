using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public struct Tiempo
    {
        public string Date { get; set; }
        public decimal Importe_total { get; set; }
    }
    public class CD_Negocio
    {
        private DateTime Fechainicio;
        private DateTime Fechafin;
        private int NumeroDias;
        public int NumClientes { get; set; }
        public int NumProductos { get; set; }
        public List<KeyValuePair<string, int>> ProductosVendidos { get; set; }
        public List<KeyValuePair<string, int>> ProductosFaltantes { get; set; }
        public List<KeyValuePair<string, int>> Empleado { get; set; }
        public List<Tiempo> Recaudacion { get; set; } //GrossRevenue
        public int TotalVentas { get; set; }
        public decimal TotalRecaudado { get; set; }
        public decimal Importes { get; set; }

        private void GetNumeros()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.Parameters.Add("@Fechainicio", System.Data.SqlDbType.DateTime).Value = Fechainicio;
                    command.Parameters.Add("@Fechafin", System.Data.SqlDbType.DateTime).Value = Fechafin;
                    // Obtener numero total de clientes
                    //command.CommandText = "SELECT COUNT(id_cliente) FROM facturas WHERE CAST(fecha AS DATE) BETWEEN @Fechainicio AND @Fechafin";
                    //NumClientes = (int)command.ExecuteScalar();

                    // Obtener numero total de productos vendidos
                    command.CommandText = "SELECT COUNT(cantidad) FROM pedido_detalle df INNER JOIN pedido f ON f.id_pedido = df.id_pedido WHERE CAST(f.fecha AS DATE) BETWEEN @Fechainicio AND @Fechafin";
                    NumProductos = (int)command.ExecuteScalar();

                    //Obtener numero de ventas
                    command.CommandText = "SELECT count(id_pedido) FROM pedido WHERE CAST(fecha AS DATE) BETWEEN @Fechainicio AND @Fechafin";
                    TotalVentas = (int)command.ExecuteScalar();
                }
            }
        }

        private void GetVentasAnalisys()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                Recaudacion = new List<Tiempo>();
                TotalRecaudado = 0;

                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    // Cambia la consulta para obtener la fecha como tipo DATE
                    command.CommandText = @"SELECT CAST(f.fecha AS date) AS Fecha, 
                                    SUM(total) AS Total
                                    FROM pedido f 
                                    WHERE CAST(f.fecha AS date) BETWEEN @Fechainicio AND @Fechafin 
                                    GROUP BY CAST(f.fecha AS date)";
                    command.Parameters.Add("@Fechainicio", System.Data.SqlDbType.Date).Value = Fechainicio;
                    command.Parameters.Add("@Fechafin", System.Data.SqlDbType.Date).Value = Fechafin;

                    var reader = command.ExecuteReader();
                    var resultadoTabla = new List<KeyValuePair<DateTime, decimal>>();
                    decimal totalImporte = 0;
                    Importes = 0;

                    while (reader.Read())
                    {
                        // Lee el valor como Date
                        DateTime fecha = reader.GetDateTime(0);
                        object totalImporteObj = reader.GetValue(1);
                        totalImporte = (totalImporteObj != DBNull.Value) ? Convert.ToDecimal(totalImporteObj) : 0;

                        resultadoTabla.Add(new KeyValuePair<DateTime, decimal>(fecha, totalImporte));
                        Importes += totalImporte;
                    }
                    TotalRecaudado += Importes;
                    reader.Close();

                    // Procesar los resultados para llenar Recaudacion
                    foreach (var item in resultadoTabla)
                    {
                        Recaudacion.Add(new Tiempo()
                        {
                            Date = item.Key.ToString("dd MMM"),
                            Importe_total = item.Value,
                        });
                    }
                }
            }
        }

        private void GetProductoAnalisys()
        {
            ProductosVendidos = new List<KeyValuePair<string, int>>();
            ProductosFaltantes = new List<KeyValuePair<string, int>>();
            Empleado = new List<KeyValuePair<string, int>>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = conexion;
                    // Obtener los tres productos mas vendidos
                    command.CommandText = @"SELECT TOP 3 p.nombre, SUM(df.cantidad) [Cantidad]
                            FROM pedido_detalle df
                            INNER JOIN producto p ON df.id_producto = p.id_producto
                            INNER JOIN pedido f ON df.id_pedido = f.id_pedido
                            WHERE CAST(fecha AS DATE) BETWEEN @Fechainicio AND @Fechafin
                            GROUP BY p.nombre
                            ORDER BY Cantidad desc";
                    command.Parameters.Add("@Fechainicio", System.Data.SqlDbType.DateTime).Value = Fechainicio;
                    command.Parameters.Add("@Fechafin", System.Data.SqlDbType.DateTime).Value = Fechafin;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductosVendidos.Add(new KeyValuePair<string, int>
                            (reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    // Obtener productos con stock bajo
                    command.CommandText = @"select nombre, stock
                            from producto
                            where stock <= 5 and activo = 1";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductosFaltantes.Add(new KeyValuePair<string, int>
                            (reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    // Obtener mejor vendedor
                    command.CommandText = @"SELECT TOP 1 (u.apellido + ' ' + u.nombre) [Nombre], COUNT(f.id_usuario) [Cantidad] 
                            FROM pedido f INNER JOIN usuario u
                            ON f.id_usuario = u.id_usuario
                            WHERE CAST(fecha AS DATE) 
                            BETWEEN @Fechainicio AND @Fechafin 
                            GROUP BY f.id_usuario, (u.apellido + ' ' + u.nombre)";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado.Add(new KeyValuePair<string, int>
                            (reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        public bool CargaDatos(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.Fechainicio || endDate != this.Fechafin)
            {
                this.Fechainicio = startDate;
                this.Fechafin = endDate;
                this.NumeroDias = (endDate - startDate).Days;

                GetNumeros();
                GetVentasAnalisys();
                GetProductoAnalisys();
                return true;
            }
            else
            {
                Console.WriteLine("datos no incializados");
                return false;
            }
        }
    }
}
