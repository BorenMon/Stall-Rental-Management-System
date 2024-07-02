using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Testing;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.View_Interfaces;
using Stall_Rental_Management_System.Views.Panel_Forms;
using System.Configuration;
using Stall_Rental_Management_System.Presenters;


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
            
            // Init MinIO Client
            MinIoUtil.InitMinioClient();
            
            // Uncomment this line for testing purposes
            // TestSetup.SetupTestUser();
            
            Application.Run(new FrmLogin(new AuthenticationService())); 
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
