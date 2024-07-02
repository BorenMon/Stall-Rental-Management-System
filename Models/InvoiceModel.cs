using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Models
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        
        [DisplayName("Invoice No")]
        [Required(ErrorMessage = "Invoice No is required.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Code must be 8 characters.")]
        public string InvoiceNo { get; set; }
        
        [DisplayName("Issued Date")]
        [Required(ErrorMessage = "Issued Date is required.")]
        [DataType(DataType.Date)]
        public DateTime IssuedDate { get; set; }
        
        [DisplayName("Rent Fee")]
        [Required(ErrorMessage = "Rent fee is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Monthly fee must be a positive number.")]
        public decimal RentFee { get; set; }
        
        [DisplayName("Electricity Cost")]
        [Required(ErrorMessage = "Electricity Cost is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Electricity Cost must be a positive number.")]
        public decimal ElectricityCost { get; set; }
        
        [DisplayName("Water Cost")]
        [Required(ErrorMessage = "Water Cost is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Water Cost must be a positive number.")]
        public decimal WaterCost { get; set; }
        
        [DisplayName("Total Amount")]
        [Required(ErrorMessage = "Total Amount is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Total Amount must be a positive number.")]
        public decimal TotalAmount { get; set; }
        
        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required.")]
        public InvoiceStatus Status { get; set; }
        
        [DisplayName("Contract ID")]
        [Required(ErrorMessage = "Contract ID is required.")]
        public int ContractId { get; set; }
        
        [DisplayName("Contract ID")]
        [Required(ErrorMessage = "Contract ID is required.")]
        public int StaffId { get; set; }
    }
}

