using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Esta clase representa la entidad PedidoDetalle
    public class PedidoDetalle
    {
        public int Id_Pedido_Detalle { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public Pedido Id_Pedido { get; set; }
        public Producto Id_Producto { get; set; }
        public float Precio { get; set; }
    }
}
