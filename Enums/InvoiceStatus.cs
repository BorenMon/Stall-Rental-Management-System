using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Enums
{
    public enum InvoiceStatus
    {
        [DisplayName("Unpaid")]
        UNPAID,
        
        [DisplayName("Paid")]
        PAID,
                
        [DisplayName("Closed")]
        CLOSED,
    }
}
