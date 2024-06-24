using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Testing;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;
<<<<<<< HEAD
using Stall_Rental_Management_System.Views.Supermarket_Contract_Forms;
using Stall_Rental_Management_System.Views.View_Interfaces;
=======
using Stall_Rental_Management_System.Views.Panel_Forms;

>>>>>>> 957b431f1fd9a25746544a1fa9c5d9e19e706722

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
            
<<<<<<< HEAD
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
=======
            // Init MinIO Client
            MinIoUtil.InitMinioClient();
            
            // Uncomment this line for testing purposes
            // TestSetup.SetupTestUser();
            
            var authService = new AuthenticationService();
            Application.Run(new FrmLogin(authService));
            
            // Application.Run(new FrmStaff(new StaffRepository(), new AuthenticationService()));
>>>>>>> 957b431f1fd9a25746544a1fa9c5d9e19e706722
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
