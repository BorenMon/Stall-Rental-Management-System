using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
