using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_ReporteVenta obj_venta = new CD_ReporteVenta();

        public List<ReporteVentas> Venta(string fechainicio, string fechafin, int id_users)
        {
            return obj_venta.Ventas(fechainicio, fechafin, id_users);
        }
    }
}
