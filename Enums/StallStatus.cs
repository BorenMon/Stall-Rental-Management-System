using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Enums
{
    public enum StallStatus
    {
        [DisplayName("Available")]
        AVAILABLE, // The stall is vacant and ready to be rented.
        
        [DisplayName("Occupied")]
        OCCUPIED, // The stall is currently rented and occupied by a vendor.
    }
}
