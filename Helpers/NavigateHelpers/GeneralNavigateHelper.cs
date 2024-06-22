using System.Windows.Forms;
using Stall_Rental_Management_System.Services;
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
    }
}