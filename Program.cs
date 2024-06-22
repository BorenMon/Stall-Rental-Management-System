using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Middlewares;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Testing;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Panel_Forms;


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
            
            // Uncomment this line for testing purposes
            TestSetup.SetupTestUser();

            // IAuthenticationService authService = new AuthenticationService();
            // var middleware = new AuthenticationMiddleware(authService);
            // middleware.Run();
            
            var staffRepository = new StaffRepository();
            Application.Run(new FrmStaff(staffRepository));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
