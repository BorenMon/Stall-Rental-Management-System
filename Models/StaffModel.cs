using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Net;

namespace Stall_Rental_Management_System.Models
{
    public class StaffModel
    {
        // Fields
        private int staffID;
        private string profileImageURL;
        private string lastNameEN;
        private string firstNameEN;
        private string lastNameKH;
        private string firstNameKH;
        private DateTime birthDate;
        private string gender;
        private string email;
        private string position;
        private string address;
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

        [DisplayName("Last Name (EN)")]
        [Required(ErrorMessage = "Last Name (EN) is required")]
        [StringLength(100, ErrorMessage = "Last Name (EN) must be at most 100 characters")]
        public string LastNameEN
        {
            get { return lastNameEN; }
            set { lastNameEN = value; }
        }

        [DisplayName("First Name (EN)")]
        [Required(ErrorMessage = "First Name (EN) is required")]
        [StringLength(100, ErrorMessage = "First Name (EN) must be at most 100 characters")]
        public string FirstNameEN
        {
            get { return firstNameEN; }
            set { firstNameEN = value; }
        }

        [DisplayName("Last Name (KH)")]
        [Required(ErrorMessage = "Last Name (KH) is required")]
        [StringLength(100, ErrorMessage = "Last Name (KH) must be at most 100 characters")]
        public string LastNameKH
        {
            get { return lastNameKH; }
            set { lastNameKH = value; }
        }

        [DisplayName("First Name (KH)")]
        [Required(ErrorMessage = "First Name (KH) is required")]
        [StringLength(100, ErrorMessage = "First Name (KH) must be at most 100 characters")]
        public string FirstNameKH
        {
            get { return firstNameKH; }
            set { firstNameKH = value; }
        }

        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "Birth Date is required")]
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        [StringLength(5, ErrorMessage = "Gender must be at most 5 characters")]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(255, ErrorMessage = "Email must be at most 255 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Position")]
        [Required(ErrorMessage = "Position is required")]
        [StringLength(100, ErrorMessage = "Position must be at most 100 characters")]
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        [DisplayName("Address")] // New Property
        [StringLength(255, ErrorMessage = "Address must be at most 255 characters")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Phone Number must be between 6 and 20 characters")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Password must be at most 255 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
