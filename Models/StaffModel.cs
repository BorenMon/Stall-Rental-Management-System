using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Stall_Rental_Management_System.Enums;


namespace Stall_Rental_Management_System.Models
{
    public class StaffModel
    {
        // Properties - Validations
        public int StaffId { get; set; }
        
        [DisplayName("Profile Image URL")]
        [StringLength(255, ErrorMessage = "Profile Image URL must be at most 255 characters.")]
        public string ProfileImageUrl { get; set; }

        [DisplayName("Last Name (EN)")]
        [Required(ErrorMessage = "Last Name (EN) is required.")]
        [StringLength(100, ErrorMessage = "Last Name (EN) must be at most 100 characters.")]
        public string LastNameEn { get; set; }

        [DisplayName("First Name (EN)")]
        [Required(ErrorMessage = "First Name (EN) is required.")]
        [StringLength(100, ErrorMessage = "First Name (EN) must be at most 100 characters.")]
        public string FirstNameEn { get; set; }

        [DisplayName("Last Name (KH)")]
        [Required(ErrorMessage = "Last Name (KH) is required.")]
        [StringLength(100, ErrorMessage = "Last Name (KH) must be at most 100 characters.")]
        public string LastNameKh { get; set; }

        [DisplayName("First Name (KH)")]
        [Required(ErrorMessage = "First Name (KH) is required.")]
        [StringLength(100, ErrorMessage = "First Name (KH) must be at most 100 characters.")]
        public string FirstNameKh { get; set; }

        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "Birth Date is required.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [StringLength(255, ErrorMessage = "Email must be at most 255 characters.")]
        public string Email { get; set; }

        [DisplayName("Position")]
        [Required(ErrorMessage = "Position is required.")]
        public StaffPosition Position { get; set; }

        [DisplayName("Address")]
        [StringLength(255, ErrorMessage = "Address must be at most 255 characters.")]
        public string Address { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Phone Number must be between 6 and 20 characters.")]
        [RegularExpression(@"^\+?[0-9]{6,20}$", ErrorMessage = "Invalid Phone Number format.")]
        public string PhoneNumber { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(255, ErrorMessage = "Password must be at most 255 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Computed Properties
        public string FullNameKh => $"{LastNameKh} {FirstNameKh}";
        public string FullNameEn => $"{LastNameEn} {FirstNameEn}";
    }
}