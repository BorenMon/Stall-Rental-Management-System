using System.Windows.Forms;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Services.Service_Interfaces;
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
                var currentUser = _authService.CurrentUser;
                UserType userType = currentUser.UserType;
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
                }
            }
        }

        private void ShowLoginForm()
        {
            using (FrmLogin loginForm = new FrmLogin(_authService))
            {
                loginForm.ShowDialog();
                if (_authService.IsAuthenticated)
                {
                    Run(); // Re-run the middleware to handle navigation after successful login
                }
            }
        }

        private void ShowVendorPanel()
        {
            using (FrmVendorPanel vendorPanel = new FrmVendorPanel())
            {
                Application.Run(vendorPanel);
            }
        }

        private void ShowStaffPanel()
        {
            using (FrmStaffPanel staffPanel = new FrmStaffPanel())
            {
                Application.Run(staffPanel);
            }
        }

        private void ShowManagerPanel()
        {
            using (FrmManagerPanel managerPanel = new FrmManagerPanel())
            {
                Application.Run(managerPanel);
            }
        }
    }
}
