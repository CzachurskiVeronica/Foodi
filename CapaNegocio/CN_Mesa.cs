using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Mesa
    {
        // Retorna la lista de la Capa de Datos menu
        private CD_Mesa obj_menu = new CD_Mesa();

        // Retorna la lista de la Capa de Datos menu
        public List<Mesa> Listar()
        {
            return obj_menu.Listar();
        }

        // Registra un nuevo menu
        public int Registrar(Mesa mesa, out string Mensaje)
        {
            return obj_menu.RegistrarMesa(mesa, out Mensaje);
        }

        // Edita un menu existente
        public bool Editar(Mesa mesa, out string Mensaje)
        {
            return obj_menu.EditarMesa(mesa, out Mensaje);
        }

        // Elimina un menu
        public bool Eliminar(Mesa mesa, out string Mensaje)
        {
            return obj_menu.EliminarMesa(mesa, out Mensaje);
        }
    }
}
