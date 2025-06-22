using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CapaDatos
{
    public class InicializadorBD
    {
        public static void VerificarOCrearBase()
        {
            // Cambiá esto según tu entorno local
            string nombreBD = "Foodi";
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScriptBD", "script.sql");

            // Conexión al servidor (sin especificar base de datos)
            string connStringServidor = "Server=localhost;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStringServidor))
            {
                conn.Open();

                // Verificar si existe la base
                SqlCommand cmdCheck = new SqlCommand($"SELECT db_id('{nombreBD}')", conn);
                object result = cmdCheck.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    Console.WriteLine("Base de datos no existe. Creando...");

                    // Leer script
                    string scriptSQL = File.ReadAllText(scriptPath);

                    // Ejecutar script
                    SqlCommand cmdScript = new SqlCommand(scriptSQL, conn);
                    cmdScript.ExecuteNonQuery();

                    Console.WriteLine("Base creada correctamente.");
                }
                else
                {
                    Console.WriteLine("La base de datos ya existe.");
                }
            }
        }
    }
}
