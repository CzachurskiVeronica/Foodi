using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Menu
    {
        // Retorna la lista de la Capa de Datos menu
        private CD_Menuu obj_menu = new CD_Menuu();

        public List<Menu> Listar()
        {
            return obj_menu.Listar();
        }

        public int Registrar(Menu menu, out string Mensaje)
        {
            return obj_menu.RegistrarMenu(menu, out Mensaje);
        }

        public bool Editar(Menu menu, out string Mensaje)
        {
            return obj_menu.EditarMenu(menu, out Mensaje);
        }

        public bool Eliminar(Menu menu, out string Mensaje)
        {
            return obj_menu.EliminarMenu(menu, out Mensaje);
        }
    }
}
