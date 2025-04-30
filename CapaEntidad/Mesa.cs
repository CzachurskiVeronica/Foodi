using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Esta clase representa la entidad Mesa
    public class Mesa
    {
        public int Id_Mesa { get; set; }
        public int Cap_Personas_Max { get; set; }
        public int Ocupado { get; set; }
    }
}
