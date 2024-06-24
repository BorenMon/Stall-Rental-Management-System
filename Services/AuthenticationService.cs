using System;
using System.Data;
using System.Data.SqlClient;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool Login(string phoneNumber, string password, UserType userType)
        {
            const string query = "spLoginUser";

            using (var connection = DatabaseUtil.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@UserType", userType.ToString());
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var hashedPasswordFromDb = reader["Password"].ToString();
                        if (AuthHelper.VerifyPassword(password, hashedPasswordFromDb))
                        {
                            CurrentUser = new User
                            {
                                PhoneNumber = phoneNumber,
                                UserType = userType,
                                LastNameEn = reader["LastNameEn"].ToString(),
                                FirstNameEn = reader["FirstNameEn"].ToString(),
                                LastNameKh = reader["LastNameKh"].ToString(),
                                FirstNameKh = reader["FirstNameKh"].ToString(),
                                BirthDate = reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : default,
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                ProfileImageUrl = reader["ProfileImageUrl"].ToString()
                            };

                            if (userType == UserType.SUPERMARKET_STAFF)
                            {
                                CurrentUser.Position = Enum.TryParse<StaffPosition>(reader["Position"].ToString(), out var position) ? position : StaffPosition.STAFF;
                            }

                            CurrentUserUtil.User = CurrentUser; // Set the current user in the static class
                            return true;
                        }
                    }
                }
                connection.Close();
            }

            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
            CurrentUserUtil.User = null; // Clear the current user in the static class
        }

        public bool IsAuthenticated => CurrentUser != null;
        public User CurrentUser { get; private set; }
    }
}