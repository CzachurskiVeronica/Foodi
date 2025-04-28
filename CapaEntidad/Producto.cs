using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Activo { get; set; }
        public int Stock { get; set; }
        public int Stock_min { get; set; }
        public Menu Menus { get; set; }
    }
}
