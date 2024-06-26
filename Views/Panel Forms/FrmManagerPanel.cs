using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Views.Panel_Forms
{
    public partial class FrmManagerPanel : Form
    {
        private readonly AuthenticationService _authService;
        public FrmManagerPanel(AuthenticationService authService)
        {
            InitializeComponent();
            _authService = authService;

            buttonStalls.Click += buttonStalls_Click;
            buttonStaffs.Click += buttonStaffs_Click;
        }

        private void buttonStalls_Click(object sender, EventArgs e)
        {
            ManagerNavigateHelper.NavigateToStallForm(this, _authService);
        }

        private void buttonStaffs_Click(object sender, EventArgs e)
        {
            ManagerNavigateHelper.NavigateToStaffForm(this, _authService);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            CurrentUserUtil.Logout(this, _authService);
        }
    }
}
