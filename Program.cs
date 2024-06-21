using Stall_Rental_Management_System.Repository;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Supermarket_Contract_Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //
            //var myView = new FrmContract();
            //new ContractPresenter(myView, new ContractRepository());
         
            //Application.Run(myView);

            Application.Run(new FrmSupportTicket());
        }
    }
}
