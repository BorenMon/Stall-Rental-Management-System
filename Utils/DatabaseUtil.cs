using System.Data.SqlClient;
using System.Configuration;

namespace Stall_Rental_Management_System.Utils
{
    public static class DatabaseUtil
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SRMSConnectionString"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
