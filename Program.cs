using System;
using System.Configuration;
using System.Windows.Forms;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Views;
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
            
            var connectionString = ConfigurationManager.ConnectionStrings["SRMS"].ConnectionString;
            
            IStaffView view = new FrmStaff();
            IStaffRepository repository = new StaffRepository(connectionString);
            new StaffPresenter(view, repository);
            Application.Run((Form)view);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
