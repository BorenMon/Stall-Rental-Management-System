using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal RentFee { get; set; }
        public ContractStatus Status { get; set; }
    }
}