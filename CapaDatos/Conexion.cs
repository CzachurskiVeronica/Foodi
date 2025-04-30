using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    // Esta clase se encarga de establecer la conexión a la base de datos
    public class Conexion
    {
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
    }
}
