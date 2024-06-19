using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmMain : Form, IMainView
    {
        public FrmMain()
        {
            InitializeComponent();
            buttonStaff.Click += delegate { ShowStaffView?.Invoke(this, EventArgs.Empty); };
        }
        
        public event EventHandler ShowStaffView;
        public void ShowLogin()
        {
            // Show login form
            var loginForm = new FrmLogin();
            loginForm.ShowDialog();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        // public void Close()
        // {
        //     this.Close();
        // }
    }
}