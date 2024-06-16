using System.Data.SqlClient;
using System.Configuration;

namespace Stall_Rental_Management_System.Utils
{
    public static class DatabaseUtil
    {
        private static SqlConnection _conn;

        public static SqlConnection GetConn()
        {
            if (_conn == null)
            {
                InitializeConn();
            }
            return _conn;
        }

        private static void InitializeConn()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SRMS"].ConnectionString;
            _conn = new SqlConnection(connectionString);
        }
    }
}
