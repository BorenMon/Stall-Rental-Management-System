using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Utils
{
    internal class MinIOObjectNameUtil
    {
        public static string GetOnlyObjectName(string minioUrl)
        {
            if (minioUrl != "google.com")
            {
                // Split the URL by '/' and '?' to extract the object name
                string[] parts = minioUrl.Split('/', '?');

                // The last part of the URL, before '?' if any, will be the object name
                string objectName = parts[parts.Length - 2];

                // Replace %20 with spaces in the object name
                objectName = objectName.Replace("%20", " ");

                // Print the object name to the console (for debugging or logging purposes)
                Console.WriteLine("Object name: " + objectName);

                // Return the extracted object name
                return objectName;
            }
            return minioUrl;
        }
    }
}
