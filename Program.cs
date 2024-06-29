using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Repository;
using Stall_Rental_Management_System.Views.Supermarket_Contract_Forms;
using Stall_Rental_Management_System.Views.Supermarket_Staff_Forms;
using Stall_Rental_Management_System.Views.InvoiceForm;

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

            Application.Run(new FrmInvoice1());

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
