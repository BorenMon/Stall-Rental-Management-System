using Minio;
namespace Stall_Rental_Management_System.Utils
{
    internal class MinIOUtil
    {
        private static MinioClient minioClient;

        public static MinioClient GetMinioClient()
        {
            if (minioClient == null)
            {
                InitializeMinioClient();
            }
            return minioClient;
        }

        private static void InitializeMinioClient()
        {
 
            minioClient = (MinioClient) new MinioClient()
                .WithEndpoint("34.87.58.157:9000")
                .WithCredentials("VixCzznb1jBsFXZ8Uv3N", "VZhsPT0LfRuAv2bz5nLvYdyOp7vSHa30tRhiDEvW")
                .Build();
        }
    }
}
