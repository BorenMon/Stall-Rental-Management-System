using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmLogin : Form, ILoginView
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public string PhoneNumber { get; }
        public string Password { get; }
        public event EventHandler Login;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}