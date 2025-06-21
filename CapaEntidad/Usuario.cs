using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Esta clase representa la entidad Usuario
    public class Usuario
        {
            public int Id_Usuario { get; set; }
            public int DNI { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime Fecha_Incorporación { get; set; }
            public string Contraseña { get; set; }
            public int Activo { get; set; }
            public Rol rol { get; set; }

    }
   
}
