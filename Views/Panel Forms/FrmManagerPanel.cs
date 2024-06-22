using System;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Views.Panel_Forms
{
    public partial class FrmManagerPanel : Form
    {
        public FrmManagerPanel()
        {
            InitializeComponent();
        }

        private void buttonStalls_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonStaffs_Click(object sender, EventArgs e)
        {
            ManagerNavigateHelper.NavigateToStaffForm(this);
        }
    }
}
