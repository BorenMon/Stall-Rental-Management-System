using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Views.Panel_Forms;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmLogin : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;

        public FrmLogin(IAuthenticationService authService)
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, authService);
        }

        public string PhoneNumber => textBoxPhoneNumber.Text;
        public string Password => textBoxPassword.Text;
        public UserType SelectedUserType => (UserType)comboBoxUserType.SelectedItem;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToVendorPanel()
        {
            var vendorPanel = new FrmVendorPanel();
            vendorPanel.Show();
        }

        public void NavigateToStaffPanel()
        {
            var StaffPanel = new FrmStaffPanel();
            StaffPanel.Show();
        }
        public void NavigateToManagerPanel()
        {
            var ManagerPanel = new FrmManagerPanel();
            ManagerPanel.Show();
        }

        public new void Close()
        {
            base.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }
    }
}