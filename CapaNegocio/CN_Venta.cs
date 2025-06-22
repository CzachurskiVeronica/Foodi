using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        // Retorna la lista de la Capa de Datos Compra
        private CD_Venta obj_venta = new CD_Venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return obj_venta.DisminuirStock(idproducto, cantidad);
        }
        public bool SumarStock(int idproducto, int cantidad)
        {
            return obj_venta.AcumularStock(idproducto, cantidad);
        }

        public bool Registrar(Pedido obj, DataTable DetalleVenta, out string Mensaje)
        {
            return obj_venta.RegistrarVenta(obj, DetalleVenta, out Mensaje);
        }
    }
}
