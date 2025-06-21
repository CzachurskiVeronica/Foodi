using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        // Retorna la lista de la Capa de Datos Usuario
        private CD_Rol obj_roles = new CD_Rol();

        // Metodo para listar los roles de usuarios
        public List<Rol> Listar()
        {
            return obj_roles.Listar();
        }

        // Metodo para obtener los roles de un usuario específico
        public List<Rol> Permisos(int id_users)
        {
            return obj_roles.Permisos(id_users);
        }
    }
}
