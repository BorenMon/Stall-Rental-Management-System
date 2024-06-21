using System;

using Stall_Rental_Management_System.Enums;


namespace Stall_Rental_Management_System.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string ProfileImageUrl { get; set; }
        public string LastNameEn { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameKh { get; set; }
        public string FirstNameKh { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public StaffPosition Position { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }
    }
}
