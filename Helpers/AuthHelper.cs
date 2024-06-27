using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Helpers
{
    public static class AuthHelper
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToUpper();
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            var hashedPasswordToCompare = HashPassword(password);
            return hashedPasswordToCompare.Equals(hashedPassword);
        }
        
        public static bool ValidatePassword(int userId, string password, UserType userType)
        {
            var tableName = userType == UserType.VENDOR ? "tbVendor" : "tbStaff";
            using (var connection = new SqlConnection(DatabaseUtil.GetConnectionString()))
            using (var command = new SqlCommand($"SELECT Password FROM {tableName} WHERE {(userType == UserType.VENDOR ? "VendorID" : "StaffID")} = @UserId", connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                var storedPasswordHash = (string)command.ExecuteScalar();
                return VerifyPassword(password, storedPasswordHash);
            }
        }

        public static void UpdatePassword(int userId, string newPassword, UserType userType)
        {
            var tableName = userType == UserType.VENDOR ? "tbVendor" : "tbStaff";
            using (var connection = new SqlConnection(DatabaseUtil.GetConnectionString()))
            using (var command = new SqlCommand($"UPDATE {tableName} SET Password = @PasswordHash WHERE {(userType == UserType.VENDOR ? "VendorID" : "StaffID")} = @UserId", connection))
            {
                var newPasswordHash = HashPassword(newPassword);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@PasswordHash", newPasswordHash);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
