using System.Windows.Forms;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Panel_Forms;

namespace Stall_Rental_Management_System.Helpers.NavigateHelpers
{
    public static class VendorNavigateHelper
    {
        public static void NavigateToVendorPanel(Form currentForm, AuthenticationService authService)
        {
            var vendorPanel = new FrmVendorPanel();
            vendorPanel.Show();
            currentForm.Hide();
            vendorPanel.FormClosed += (s, args) => currentForm.Close();
        }
    }
}
