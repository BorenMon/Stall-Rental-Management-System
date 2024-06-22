using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Panel_Forms;


namespace Stall_Rental_Management_System.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationMiddleware(IAuthenticationService authService)
        {
            _authService = authService;
        }

        public void Run()
        {
            if (!_authService.IsAuthenticated)
            {
                ShowLoginForm();
            }
            else
            {
                var currentUser =  CurrentUserUtil.User; // Use the static class to get the current user
                var userType = currentUser.UserType;
                switch (userType)
                {
                    case UserType.VENDOR:
                        ShowVendorPanel();
                        break;
                    case UserType.SUPERMARKET_STAFF:
                        if (currentUser.Position == StaffPosition.MANAGER)
                            ShowManagerPanel();
                        else ShowStaffPanel();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void ShowLoginForm()
        {
            using (var loginForm = new FrmLogin(_authService))
            {
                loginForm.ShowDialog();
                if (_authService.IsAuthenticated)
                {
                    Run(); // Re-run the middleware to handle navigation after successful login
                }
            }
        }

        private static void ShowVendorPanel()
        {
            using (var vendorPanel = new FrmVendorPanel())
            {
                Application.Run(vendorPanel);
            }
        }

        private static void ShowStaffPanel()
        {
            using (var staffPanel = new FrmStaffPanel())
            {
                Application.Run(staffPanel);
            }
        }

        private static void ShowManagerPanel()
        {
            using (var managerPanel = new FrmManagerPanel())
            {
                Application.Run(managerPanel);
            }
        }
    }
}
