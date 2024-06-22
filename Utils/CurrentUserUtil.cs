using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Utils
{
    public static class CurrentUserUtil
    {
        public static User User { get; set; }
        
        // Method to set the user for testing purposes
        public static void SetTestUser(User user)
        {
            User = user;
        }
    }
}