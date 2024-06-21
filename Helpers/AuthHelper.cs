using System;
using System.Security.Cryptography;
using System.Text;

namespace Stall_Rental_Management_System.Helpers
{
    public static class AuthHelper
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToUpper();
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedPasswordToCompare = HashPassword(password);
            return hashedPasswordToCompare.Equals(hashedPassword);
        }
    }
}
