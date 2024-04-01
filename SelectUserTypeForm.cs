using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Minio;
using Minio.DataModel.Args;
using Stall_Rental_Management_System.Utils;
using ComponentFactory.Krypton.Toolkit;

namespace Stall_Rental_Management_System
{
    public partial class SelectUserTypeForm : KryptonForm
    {
        private readonly MinioClient m_client;
        private readonly SqlConnection conn;

        public SelectUserTypeForm ()
        {
            InitializeComponent();
            m_client = MinioClientUtil.GetMinioClient();
            conn = SQLConnectionUtil.GetConn();
            TestMinio();
            TestSQLServer();
        }

        private void TestMinio ()
        {
            var bucketName = "srms";

            ListObjectsArgs args = new ListObjectsArgs()
                .WithBucket(bucketName);

            var observable = m_client.ListObjectsAsync(args);

            var subscription = observable.Subscribe(
                item => Console.WriteLine($"Object: {item.Key}"),
                ex => Console.WriteLine($"OnError: {ex}"),
                () => Console.WriteLine($"Listed all objects in bucket {bucketName}\n")
            );
        }

        private void TestSQLServer ()
        {
            conn.Open();
            // Perform database operations
            SqlCommand cmd = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string tableName = reader["TABLE_NAME"].ToString();
                Console.WriteLine(tableName);
            }
            conn.Close();
        }
    }
}
