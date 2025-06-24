using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVentas
    {
        public string FechaVenta { get; set; }
        public string Nro_factura { get; set; }
        public string Importe_total { get; set; }
        public string Vendedor { get; set; }
        public string Codigo_producto { get; set; }
        public string NombreProducto { get; set; }
        public string NombreCategoria { get; set; }
        public string Precio { get; set; }
        public string Subtotal { get; set; }
    }
}

