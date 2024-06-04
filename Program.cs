using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Views.Supermarket_Staff_Forms;

namespace Stall_Rental_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FormLogin());
            
=======
            Application.Run(new FrmStaff());
>>>>>>> 241d8d214c7a5fea3baf3fb586db0363aa7a6c17
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
