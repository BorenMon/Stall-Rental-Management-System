using Stall_Rental_Management_System.Views.Panel_Forms;

namespace Stall_Rental_Management_System.Helpers
{
    public static class NavigateHelper
    {
        public static void NavigateToVendorPanel()
        {
            var vendorPanel = new FrmVendorPanel();
            vendorPanel.Show();
        }

        public static void NavigateToStaffPanel()
        {
            var staffPanel = new FrmStaffPanel();
            staffPanel.Show();
        }
        public static void NavigateToManagerPanel()
        {
            var managerPanel = new FrmManagerPanel();
            managerPanel.Show();
        }
    }
}
