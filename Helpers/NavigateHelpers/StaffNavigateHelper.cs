using System.Windows.Forms;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Panel_Forms;

namespace Stall_Rental_Management_System.Helpers.NavigateHelpers
{
    public static class StaffNavigateHelper
    {
        public static void NavigateToVendorForm(Form currentForm, AuthenticationService authService)
        {
            var vendorRepository = new VendorRepository();
            var vendorForm = new FrmVendor(vendorRepository, authService);
            vendorForm.Show();
            currentForm.Hide();
            vendorForm.FormClosed += (s, args) => currentForm.Close();
        }
        
        public static void NavigateToStallForm(Form currentForm, AuthenticationService authService)
        {
            var repo = new StallRepository();
            var form = new FrmStallForStaff(repo, authService);
            form.Show();
            currentForm.Hide();
            form.FormClosed += (s, args) => currentForm.Close();
        }
        
        public static void NavigateToStaffPanel(Form currentForm, AuthenticationService authService)
        {
            var staffPanel = new FrmStaffPanel(authService);
            staffPanel.Show();
            currentForm.Hide();
            staffPanel.FormClosed += (s, args) => currentForm.Close();
        }
    }
}
