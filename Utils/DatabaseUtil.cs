using System.Data.SqlClient;
using System.Configuration;

namespace Stall_Rental_Management_System.Utils
{
    internal class DatabaseUtil
    {
        private static SqlConnection conn;

        public static SqlConnection GetConn()
        {
            if (conn == null)
            {
                InitializeConn();
            }
            return conn;
        }

        private static void InitializeConn()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SRMS"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }
    }
}
