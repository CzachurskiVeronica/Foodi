﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Esta clase representa la entidad Pedido
    public class Pedido
    {
        public int Id_Pedido { get; set; }
        public float Total { get; set; }
        public string Fecha { get; set; }
        public Pago Id_Pago { get; set; }
        public Usuario Id_Usuario { get; set; }
        public Mesa Id_Mesa { get; set; }
        public List<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
