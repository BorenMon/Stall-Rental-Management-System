using System;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Testing
{
    public class TestSetup
    {
        public static void SetupTestUser()
        {
            var testUser = new User
            {
                UserId = 1,
                ProfileImageUrl = null,
                LastNameEn = "Doe",
                FirstNameEn = "John",
                LastNameKh = "ដូ",
                FirstNameKh = "ជន",
                BirthDate = new DateTime(1990, 1, 1),
                Gender = "Male",
                Email = "johndoe@example.com",
                Position = StaffPosition.MANAGER,
                Address = "123 Test Street",
                PhoneNumber = "1234567890",
                UserType = UserType.SUPERMARKET_STAFF
            };

            CurrentUserUtil.SetTestUser(testUser);
        }
    }
}