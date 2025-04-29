using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Instalaciones
{
    public class OpcionesComboButton
    {
        public string Texto { get; set; }
        public object Valor { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}