using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Minio;
using Minio.DataModel.Args;

namespace Stall_Rental_Management_System.Utils
{
    public static class MinIoUtil
    {
        private static MinioClient MinioClient { get; set; }
        
        public static MinioClient GetMinioClient()
        {
            var endpoint = ConfigurationManager.AppSettings["MinioEndpoint"];
            var accessKey = ConfigurationManager.AppSettings["MinioAccessKey"];
            var secretKey = ConfigurationManager.AppSettings["MinioSecretKey"];
            
            return (MinioClient) new MinioClient()
                .WithEndpoint(endpoint)
                .WithCredentials(accessKey, secretKey)
                .Build();
        }

        public static void InitMinioClient()
        {
            var endpoint = ConfigurationManager.AppSettings["MinioEndpoint"];
            var accessKey = ConfigurationManager.AppSettings["MinioAccessKey"];
            var secretKey = ConfigurationManager.AppSettings["MinioSecretKey"];
            
            MinioClient = (MinioClient) new MinioClient()
                .WithEndpoint(endpoint)
                .WithCredentials(accessKey, secretKey)
                .Build();
        }

        public static async Task UploadFileAsync(string objectName, Stream data, string contentType, string bucketName)
        {
            var bucketExists = await MinioClient.BucketExistsAsync(new BucketExistsArgs().WithBucket(bucketName));
            if (!bucketExists)
            {
                await MinioClient.MakeBucketAsync(new MakeBucketArgs().WithBucket(bucketName));
            }

            var putObjectArgs = new PutObjectArgs()
                .WithBucket(bucketName)
                .WithObject(objectName)
                .WithStreamData(data)
                .WithObjectSize(data.Length)
                .WithContentType(contentType);
            await MinioClient.PutObjectAsync(putObjectArgs);
        }

        public static string GetFileUrl(string objectName, string bucketName)
        {
            return MinioClient.PresignedGetObjectAsync(new PresignedGetObjectArgs().WithBucket(bucketName).WithObject(objectName).WithExpiry(60 * 60 * 24)).Result;
        }
        
        public static string GetContentType(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                default:
                    return "application/octet-stream";
            }
        }
        public static string GenerateRandomObjectName(string prefix, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return $"{prefix}_{DateTime.Now:yyyyMMddHHmmssfff}_{randomString}";
        }

        public static string GenerateFileUrl(string objectName, string bucketName)
        {
            return $"http://{ConfigurationManager.AppSettings["MinioEndpoint"]}/{bucketName}/{objectName}";
        }
    }
}