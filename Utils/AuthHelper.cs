using System.Security.Cryptography;
using System.Text;
using System;

namespace Stall_Rental_Management_System.Utils
{
    public static class AuthHelper
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedPasswordToCompare = HashPassword(password);
            return hashedPasswordToCompare.Equals(hashedPassword);
        }
    }
}
