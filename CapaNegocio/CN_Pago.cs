using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Pago
    {
        // Retorna la lista de la Capa de Datos Pago
        private CD_Pago obj_Pago = new CD_Pago();

        // Retorna la lista de la Capa de Datos Pago
        public List<Pago> Listar()
        {
            return obj_Pago.Listar();
        }

        // Registra un nuevo Pago
        public int Registrar(Pago Pago, out string Mensaje)
        {
            return obj_Pago.RegistrarPago(Pago, out Mensaje);
        }

        // Edita un Pago existente
        public bool Editar(Pago Pago, out string Mensaje)
        {
            return obj_Pago.EditarPago(Pago, out Mensaje);
        }

        // Elimina un Pago
        public bool Eliminar(Pago Pago, out string Mensaje)
        {
            return obj_Pago.EliminarPago(Pago, out Mensaje);
        }
    }
}
