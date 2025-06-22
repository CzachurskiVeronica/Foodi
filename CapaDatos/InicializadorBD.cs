using System;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class InicializadorBD
    {
        public static void VerificarOCrearBase()
        {
            string nombreBD = "Foodi";
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScriptBD", "Foodie.sql");

            bool baseCreadaAhora = false; // Para saber si acaba de crearse la BD

            // 1. Conectar a master para verificar si existe la base y crearla si no
            string connMaster = "Data Source=EV-NT-ZNORTE-1\\BD_CZACHURSKI;Initial Catalog=master;Integrated Security=True";

            using (SqlConnection connMasterConn = new SqlConnection(connMaster))
            {
                connMasterConn.Open();

                SqlCommand cmdCheck = new SqlCommand($"SELECT db_id('{nombreBD}')", connMasterConn);
                object result = cmdCheck.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    Console.WriteLine("Base de datos no existe. Creando...");

                    SqlCommand cmdCreate = new SqlCommand($"CREATE DATABASE {nombreBD}", connMasterConn);
                    cmdCreate.ExecuteNonQuery();

                    Console.WriteLine("Base creada correctamente.");
                    baseCreadaAhora = true;
                }
                else
                {
                    Console.WriteLine("La base de datos ya existe.");
                }
            }

            if (baseCreadaAhora)
            {
                string connFoodi = $"Data Source=EV-NT-ZNORTE-1\\BD_CZACHURSKI;Initial Catalog={nombreBD};Integrated Security=True";
                string script = File.ReadAllText(scriptPath);

                // Separar el script por líneas con solo "GO" (SQL Server batch separator)
                string[] comandos = script.Split(new[] { "\r\nGO\r\n", "\nGO\n", "\rGO\r" }, StringSplitOptions.RemoveEmptyEntries);

                using (SqlConnection connFoodiConn = new SqlConnection(connFoodi))
                {
                    connFoodiConn.Open();

                    for (int i = 0; i < comandos.Length; i++)
                    {
                        string comando = comandos[i];
                        if (string.IsNullOrWhiteSpace(comando))
                            continue;

                        using (SqlCommand cmd = new SqlCommand(comando, connFoodiConn))
                        {
                            cmd.CommandTimeout = 600; // Opcional: para scripts largos, aumenta el timeout
                            cmd.ExecuteNonQuery();
                        }

                        if (i == comandos.Length - 1)
                        {
                            Console.WriteLine("Llegamos al último batch del script.");
                        }
                    }
                }

                Console.WriteLine("Script ejecutado correctamente.");
            }
        }
    }
}
