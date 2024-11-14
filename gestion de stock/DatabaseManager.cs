using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    public static class DatabaseManager
    {
        private static string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=gestionDeStock;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
