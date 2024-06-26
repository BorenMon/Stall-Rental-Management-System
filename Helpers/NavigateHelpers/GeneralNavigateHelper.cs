using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;


namespace Stall_Rental_Management_System.Helpers.NavigateHelpers
{
    public static class GeneralNavigateHelper
    {
        public static void NavigateToLoginForm(Form currentForm, AuthenticationService authService)
        {
            var loginForm = new FrmLogin(authService);
            loginForm.Show();
            currentForm.Hide();
            loginForm.FormClosed += (s, args) => currentForm.Close();
        }

        public static void NavigateToPanelForm(Form view, AuthenticationService authService)
        {
            var currentUser = CurrentUserUtil.User;
            if (currentUser.UserType == UserType.SUPERMARKET_STAFF && currentUser.Position == StaffPosition.MANAGER) 
                ManagerNavigateHelper.NavigateToManagerPanel(view, authService);
        }
    }
}