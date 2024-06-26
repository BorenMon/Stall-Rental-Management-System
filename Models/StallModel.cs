using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using System;


namespace Stall_Rental_Management_System.Models
{
    public class StallModel
    {
        // Properties - Validations
        public int StallId { get; set; }

        [DisplayName("Code")]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Code must be 5 characters.")]
        public string Code { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required.")]
        public StallStatus Status { get; set; }

        [DisplayName("Type")]
        [StringLength(50, ErrorMessage = "Type must be at most 50 characters.")]
        public string Type { get; set; }

        [DisplayName("Size")]
        [Required(ErrorMessage = "Size is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "Size must be a positive number.")]
        public float Size { get; set; }

        [DisplayName("Monthly Fee")]
        [Required(ErrorMessage = "Monthly fee is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Monthly fee must be a positive number.")]
        public decimal MonthlyFee { get; set; }

        [DisplayName("Location")]
        [StringLength(255, ErrorMessage = "Location must be at most 255 characters.")]
        public string Location { get; set; }

        // Computed Properties
        public string ConvertedType => EnumHelper.ConvertToReadableFormat(Type);
        public string ConvertedStatus => EnumHelper.GetDisplayName(Status);
    }

    public class StallImageModel
    {
        public int StallImageID { get; set; }
        public string URL { get; set; }
        public string FileName { get; set; }
        public int StallID { get; set; }
    }
}