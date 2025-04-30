using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        // Retorna la lista de la Capa de Datos Usuario
        private CD_Usuario obj_usuario = new CD_Usuario();

        // Retorna la lista de la Capa de Datos Usuario
        public List<Usuario> Listar()
        {
            return obj_usuario.Listar();
        }

        // Registra un usuario
        public int Registrar(Usuario user, out string Mensaje)
        {
            return obj_usuario.RegistrarUsuario(user, out Mensaje);
        }

        // Edita un usuario
        public bool Editar(Usuario user, out string Mensaje)
        {
            return obj_usuario.EditarUsuario(user, out Mensaje);
        }

        // Elimina un usuario
        public bool Eliminar(Usuario user, out string Mensaje)
        {
            return obj_usuario.EliminarUsuario(user, out Mensaje);
        }
    }
}
