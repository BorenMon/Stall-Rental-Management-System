using System.Windows.Forms;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Services;

namespace Stall_Rental_Management_System.Utils
{
    public static class CurrentUserUtil
    {
        public static User User { get; set; }
        
        // Method to set the user for testing purposes
        public static void SetTestUser(User user)
        {
            User = user;
        }

        public static void Logout(Form form, AuthenticationService authService)
        {
            var result = MessageBox.Show(
                @"Are you sure you want to logout?",
                @"Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;
            authService.Logout();
            MessageBox.Show(@"Logout successfully!");
            GeneralNavigateHelper.NavigateToLoginForm(form, authService);
        }
    }
}