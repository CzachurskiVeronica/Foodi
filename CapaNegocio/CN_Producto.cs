using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Producto
    {
        // Se instancia el objeto de la Capa de Datos
        private CD_Producto obj_productos = new CD_Producto();

        // Listar productos
        public List<Producto> Listar()
        {
            return obj_productos.Listar();
        }

        // Registrar un nuevo producto
        public int Registrar(Producto producto, out string Mensaje)
        {
            return obj_productos.RegistrarProducto(producto, out Mensaje);
        }

        // Editar producto existente
        public bool Editar(Producto producto, out string Mensaje)
        {
            return obj_productos.EditarProducto(producto, out Mensaje);
        }

        // Eliminar producto
        public bool Eliminar(Producto producto, out string Mensaje)
        {
            return obj_productos.EliminarProducto(producto, out Mensaje);
        }
    }
}