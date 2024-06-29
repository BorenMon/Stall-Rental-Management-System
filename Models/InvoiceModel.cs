using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    public class InvoiceModel
    {
        public int InvoiceID { get; set; }
        public string FileURL { get; set; }
        public string InvoiceNO { get; set; }
        public DateTime IssuedDate { get; set; }
        public decimal RentFee { get; set; }
        public decimal ElectricityCost { get; set; }
        public decimal WaterCost { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string ContractID { get; set; }
        public string StaffID { get; set; }
    }
}

