using System.Windows.Forms;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Views;

namespace Stall_Rental_Management_System.Helpers.NavigateHelpers
{
    public static class ManagerNavigateHelper
    {
        public static void NavigateToStaffForm(Form currentForm)
        {
            var staffRepository = new StaffRepository();
            var staffForm = new FrmStaff(staffRepository);
            staffForm.Show();
            currentForm.Hide();
            staffForm.FormClosed += (s, args) => currentForm.Close();
        }
    }
}
