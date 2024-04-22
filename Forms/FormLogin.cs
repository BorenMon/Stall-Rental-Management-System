using Minio.DataModel.Args;
using Minio;
using Stall_Rental_Management_System.Utils;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stall_Rental_Management_System
{
    public partial class FormLogin : Form
    {
        private readonly MinioClient minio;
        private readonly SqlConnection dbConn;

        public FormLogin()
        {
            InitializeComponent();
            minio = MinIOUtil.GetMinioClient();
            dbConn = DatabaseUtil.GetConn();
            TestMinio();
            TestDatabase();
        }

        private void TestMinio()
        {
            var bucketName = "srms";

            ListObjectsArgs args = new ListObjectsArgs()
                .WithBucket(bucketName);

            var observable = minio.ListObjectsAsync(args);

            var subscription = observable.Subscribe(
                item => Console.WriteLine($"Object: {item.Key}"),
                ex => Console.WriteLine($"OnError: {ex}"),
                () => Console.WriteLine($"Listed all objects in bucket {bucketName}\n")
            );
        }

        private void TestDatabase()
        {
            dbConn.Open();
            // Perform database operations
            SqlCommand cmd = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", dbConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string tableName = reader["TABLE_NAME"].ToString();
                Console.WriteLine(tableName);
            }
            dbConn.Close();
        }
    }
}
