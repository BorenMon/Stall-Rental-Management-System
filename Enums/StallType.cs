using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Enums
{
    public enum StallType
    {
        [DisplayName("Retail Stall")]
        RETAIL_STALL, // Designed for selling goods directly to customers.

        [DisplayName("Food Stall")]
        FOOD_STALL, // Equipped for food preparation and sales, typically includes necessary facilities for hygiene and food safety.

        [DisplayName("Service Stall")]
        SERVICE_STALL, // Meant for businesses that provide services, such as beauty salons, repair shops, etc.

        [DisplayName("Wholesale Stall")]
        WHOLESALE_STALL, // For businesses that sell goods in large quantities, usually to other businesses.

        [DisplayName("Boutique Stall")]
        BOUTIQUE_STALL, // For small, specialized shops often focused on fashion and accessories.

        [DisplayName("Market Stall")]
        MARKET_STALL, // Typical of open-air markets, selling a variety of goods.

        [DisplayName("Kiosk Stall")]
        KIOSK_STALL, // Small booth or stand, often found in malls or shopping centers.

        [DisplayName("Craft Stall")]
        CRAFT_STALL, // For selling handmade crafts and artisanal goods.

        [DisplayName("Pop-Up Stall")]
        POPUP_STALL // For businesses that operate on a temporary basis, often in various locations.
    }
}