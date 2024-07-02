using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Enums
{
    public enum ContractStatus
    {
        [DisplayName("Active")]
        ACTIVE, // The contract is currently in effect.
        
        [DisplayName("Closed")]
        CLOSED, // The contract has been closed.
    }
}
