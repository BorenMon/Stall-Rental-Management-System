using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Utils
{
    internal class MinIOObjectNameUtil
    {
        public static string GetOnlyObjectName(String minioUrl)
        {
            //string minioUrl = "http://35.240.136.224:9000/srms/DartLangSpec-v2.2.pdf?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=VixCzznb1jBsFXZ8Uv3N%2F20240604%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240604T184535Z&X-Amz-Expires=604800&X-Amz-SignedHeaders=host&X-Amz-Signature=652cc5cc6c630daa7b8ebb3c1d4749382820578ad14630121099f154b731466f";

            // Split the URL by '/' and '?' to extract the object name
            string[] parts = minioUrl.Split('/', '?');

            // The last part of the URL, before '?' if any, will be the object name
            string objectName = parts[parts.Length - 2];

            Console.WriteLine("Object name: " + objectName);
            return objectName;
        }
    }
}
