using System.Windows.Forms;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Panel_Forms;

namespace Stall_Rental_Management_System.Helpers.NavigateHelpers
{
    public static class ManagerNavigateHelper
    {
        public static void NavigateToStaffForm(Form currentForm, AuthenticationService authService)
        {
            var staffRepository = new StaffRepository();
            var staffForm = new FrmStaff(staffRepository, authService);
            staffForm.Show();
            currentForm.Hide();
            staffForm.FormClosed += (s, args) => currentForm.Close();
        }
        
        public static void NavigateToContractForm(Form currentForm, AuthenticationService authService)
        {
            var form = new FrmContractForManager(authService);
            form.Show();
            currentForm.Hide();
            form.FormClosed += (s, args) => currentForm.Close();
        }
        
        public static void NavigateToStallForm(Form currentForm, AuthenticationService authService)
        {
            var repository = new StallRepository();
            var form = new FrmStallForManager(repository, authService);
            form.Show();
            currentForm.Hide();
            form.FormClosed += (s, args) => currentForm.Close();
        }
        
        public static void NavigateToManagerPanel(Form currentForm, AuthenticationService authService)
        {
            var staffForm = new FrmManagerPanel(authService);
            staffForm.Show();
            currentForm.Hide();
            staffForm.FormClosed += (s, args) => currentForm.Close();
        }
    }
}
