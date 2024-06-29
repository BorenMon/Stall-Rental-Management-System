using System;
using System.Data.SqlClient;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Testing
{
    public static class TestSetup
    {
        public static void SetupTestUser()
        {
            User testUser = null;
            using (var connection = new SqlConnection(DatabaseUtil.GetConnectionString()))
            using (var command = new SqlCommand("SELECT * FROM tbStaff WHERE StaffID = 1", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read()) // Ensure there's a result to read
                    {
                        var genderString = reader.GetString(reader.GetOrdinal("Gender"));
                        Enum.TryParse(genderString, true, out Gender gender);
                        
                        testUser = new User
                        {
                            UserId = reader.GetInt32(reader.GetOrdinal("StaffID")),
                            ProfileImageUrl = reader.GetString(reader.GetOrdinal("ProfileImageURL")),
                            LastNameEn = reader.GetString(reader.GetOrdinal("LastNameEN")),
                            FirstNameEn = reader.GetString(reader.GetOrdinal("FirstNameEN")),
                            LastNameKh = reader.GetString(reader.GetOrdinal("LastNameKH")),
                            FirstNameKh = reader.GetString(reader.GetOrdinal("FirstNameKH")),
                            BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                            Gender = gender,
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Position = (StaffPosition)Enum.Parse(typeof(StaffPosition), reader.GetString(reader.GetOrdinal("Position")), true),
                            Address = reader.GetString(reader.GetOrdinal("Address")),
                            PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            UserType = UserType.SUPERMARKET_STAFF // Assuming UserType is set to SUPERMARKET_STAFF
                        };
                    }
                }
            }

            if (testUser != null)
            {
                CurrentUserUtil.SetTestUser(testUser);
            }
            else
            {
                throw new InvalidOperationException("Test user not found in the database.");
            }
        }
    }
}
