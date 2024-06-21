using System;
using System.Data.SqlClient;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private User _currentUser;
        
        public bool Login(string phoneNumber, string password, UserType userType)
        {
            string tableName = userType == UserType.VENDOR ? "tbVendor" : "tbStaff";
            string query = $"SELECT * FROM {tableName} WHERE PhoneNumber = @PhoneNumber";

            using (SqlConnection connection = DatabaseUtil.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string hashedPasswordFromDb = reader["Password"].ToString();
                        if (AuthHelper.VerifyPassword(password, hashedPasswordFromDb))
                        {
                            _currentUser = new User
                            {
                                PhoneNumber = phoneNumber,
                                UserType = userType,
                                LastNameEn = reader["LastNameEN"].ToString(),
                                FirstNameEn = reader["FirstNameEN"].ToString(),
                                LastNameKh = reader["LastNameKH"].ToString(),
                                FirstNameKh = reader["FirstNameKH"].ToString(),
                                BirthDate = reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : default,
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                ProfileImageUrl = reader["ProfileImageURL"].ToString()
                            };

                            if (userType == UserType.SUPERMARKET_STAFF)
                            {
                                _currentUser.Position = Enum.TryParse<StaffPosition>(reader["Position"].ToString(), out var position) ? position : StaffPosition.STAFF;
                            }

                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public void Logout()
        {
            _currentUser = null;
        }

        public bool IsAuthenticated => _currentUser != null;
        public User CurrentUser => _currentUser;
    }
}