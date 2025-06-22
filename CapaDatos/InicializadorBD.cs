using System;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class InicializadorBD
    {
        /// <summary>
        /// Verifica si la base de datos existe. Si no, la crea y ejecuta un script SQL para inicializarla.
        /// </summary>
        public static void VerificarOCrearBase()
        {
            // Nombre de la base de datos a crear
            string nombreBD = "NombreDeLaBase";

            // Ruta del archivo de script SQL que contiene las tablas y datos iniciales
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScriptBD", "Foodie.sql");

            // Bandera para saber si la base fue creada durante esta ejecución
            bool baseCreadaAhora = false;

            // Cadena de conexión a la base "master", necesaria para crear una nueva base
            string cadenaConexionMaster = "Data Source=SERVIDOR\\INSTANCIA;Initial Catalog=master;Integrated Security=True";

            // Conectar a 'master' para verificar si existe la base
            using (SqlConnection conexion = new SqlConnection(cadenaConexionMaster))
            {
                conexion.Open();

                SqlCommand cmdCheck = new SqlCommand($"SELECT db_id('{nombreBD}')", conexion);
                object result = cmdCheck.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    Console.WriteLine("La base de datos no existe. Creando...");

                    SqlCommand cmdCrear = new SqlCommand($"CREATE DATABASE {nombreBD}", conexion);
                    cmdCrear.ExecuteNonQuery();

                    Console.WriteLine("Base de datos creada correctamente.");
                    baseCreadaAhora = true;
                }
                else
                {
                    Console.WriteLine("La base de datos ya existe.");
                }
            }

            // Si la base fue recién creada, ejecutar el script de creación de tablas, procedimientos, etc.
            if (baseCreadaAhora)
            {
                string cadenaConexionBase = $"Data Source=SERVIDOR\\INSTANCIA;Initial Catalog={nombreBD};Integrated Security=True";

                // Leer contenido del archivo .sql
                string scriptCompleto = File.ReadAllText(scriptPath);

                // Separar por lotes usando "GO" como delimitador
                string[] comandos = scriptCompleto.Split(new[] { "\r\nGO\r\n", "\nGO\n", "\rGO\r" }, StringSplitOptions.RemoveEmptyEntries);

                using (SqlConnection conexionBase = new SqlConnection(cadenaConexionBase))
                {
                    conexionBase.Open();

                    foreach (string comando in comandos)
                    {
                        if (string.IsNullOrWhiteSpace(comando)) continue;

                        using (SqlCommand cmd = new SqlCommand(comando, conexionBase))
                        {
                            cmd.CommandTimeout = 600; // Aumentar el tiempo límite si el script es largo
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Script ejecutado correctamente.");
            }
        }
    }
}
