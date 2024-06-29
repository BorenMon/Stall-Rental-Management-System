using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Models
{
    internal class ContractModel
    {
        // Properties
        [DisplayName("Contract ID")]
        public int ContractId { get; set; }

        [DisplayName("File URL")]
        [Required(ErrorMessage = "File URL is required.")]
        [StringLength(500, ErrorMessage = "File URL must be at most 500 characters.")]
        public string FileUrl { get; set; }

        [DisplayName("Code")]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(8, ErrorMessage = "Last Name (EN) must be at most 8 characters.")]
        public string Code { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required.")]
        public ContractStatus Status { get; set; }

        [DisplayName("Start Date")]
        [Required(ErrorMessage = "Start Date is required.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [Required(ErrorMessage = "End Date is required.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DisplayName("Stall ID")]
        [Required(ErrorMessage ="Stall ID is required.")]
        public int StallId { get; set; }

        [DisplayName("Staff ID")]
        [Required(ErrorMessage = "Staff ID is required.")]
        public int StaffId { get; set; }

        [DisplayName("Vendor ID")]
        [Required(ErrorMessage = "Vendor ID is required.")]
        public int VendorId { get; set; }
    }
}
