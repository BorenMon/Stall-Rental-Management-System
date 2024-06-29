using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Views.Panel_Forms
{
    public partial class FrmStaffPanel : Form
    {
        private readonly AuthenticationService _authService;
        public FrmStaffPanel(AuthenticationService authService)
        {
            InitializeComponent();
            
            _authService = authService;
        }

        private void buttonStalls_Click(object sender, EventArgs e)
        {
            StaffNavigateHelper.NavigateToStallForm(this, _authService);
        }

        private void buttonVendors_Click(object sender, EventArgs e)
        {
            StaffNavigateHelper.NavigateToVendorForm(this, _authService);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            CurrentUserUtil.Profile(this, _authService);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            CurrentUserUtil.Logout(this, _authService);
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            StaffNavigateHelper.NavigateToContractForm(this, _authService);
        }
    }
}
