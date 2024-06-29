using System;
using System.Text;

namespace Stall_Rental_Management_System.Utils
{
    public static class CodeGeneratorUtil
    {
        private static readonly Random Random = new Random();

        public static string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringBuilder = new StringBuilder(length);

            for (var i = 0; i < length; i++)
            {
                var randomIndex = Random.Next(chars.Length);
                stringBuilder.Append(chars[randomIndex]);
            }

            return stringBuilder.ToString();
        }
    }
}