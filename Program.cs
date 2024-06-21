using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Middlewares;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Views;


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

            IAuthenticationService authService = new AuthenticationService();
            AuthenticationMiddleware middleware = new AuthenticationMiddleware(authService);
            middleware.Run();
            
            // Application.Run(new FrmStaff());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
