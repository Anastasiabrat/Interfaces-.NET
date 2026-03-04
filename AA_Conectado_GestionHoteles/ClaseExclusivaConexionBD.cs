using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_Conectado_GestionHoteles
{
    // 1. Hago la clase publica
    public class ClaseExclusivaConexionBD
    {
        // 2. Ruta a BD
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temp\\xtreme.mdb";

        public OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
