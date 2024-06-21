using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Stall_Rental_Management_System.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly string _connectionString;
        private User _currentUser;
        public AuthenticationService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SRMSConnectionString"].ConnectionString;
        }
        
        public bool Login(string phoneNumber, string password, UserType userType)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = string.Empty;

                switch (userType)
                {
                    case UserType.VENDOR:
                        query = "SELECT PhoneNumber, Password FROM tbVendor WHERE PhoneNumber = @phoneNumber AND Password = @password";
                        break;
                    case UserType.SUPERMARKET_STAFF:
                        query = "SELECT PhoneNumber, Password FROM tbStaff WHERE PhoneNumber = @phoneNumber AND Password = @password";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(userType), userType, null);
                }

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _currentUser = new User
                            {
                                Username = phoneNumber,
                                Password = password,
                                UserType = userType
                            };
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public void Logout()
        {
            IsAuthenticated = false;
            CurrentUser = null;
        }

        public bool IsAuthenticated { get; private set; }

        public string CurrentUser { get; private set; }
    }
}