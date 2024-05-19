using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Stall_Rental_Management_System.Models
{
    public class StaffModel
    {
        // Fields
        private int staffID;
        private string profileImageURL;
        private string lastName;
        private string firstName;
        private string gender;
        private string email;
        private string position;
        private string phoneNumber;
        private string password;

        // Properties - Validations
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string ProfileImageURL 
        { 
            get { return profileImageURL; } 
            set { profileImageURL = value; } 
        }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(15, ErrorMessage = "Last Name must be at most 15 characters")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(15, ErrorMessage = "First Name must be at most 15 characters")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DisplayName("Gender")]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DisplayName("Email")]
        [StringLength(50, ErrorMessage = "Email must be at most 50 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Position")]
        [Required(ErrorMessage = "Position is required")]
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Phone Number must be between 6 and 15 characters")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(25, ErrorMessage = "Phone Number must be between 6 and 15 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
