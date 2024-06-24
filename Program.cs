using System;
using System.Configuration;
using System.Windows.Forms;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Supermarket_Contract_Forms;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            // Initialize services
            IAuthenticationService authenticationService = new AuthenticationService();
            IAuthorizationService authorizationService = new AuthorizationService(authenticationService);

            // Initialize views
            ILoginView loginView = new FrmLogin();
            IMainView mainView = new FrmMain();

            // Initialize presenters
            LoginPresenter loginPresenter = new LoginPresenter(loginView, authenticationService);
            MainPresenter mainPresenter = new MainPresenter(mainView, sqlConnectionString, authenticationService, authorizationService);

            // Show the main form
            Application.Run(new FrmVendor());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
