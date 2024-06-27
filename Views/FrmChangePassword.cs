using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Views
{
    public partial class FrmChangePassword : Form
    {
        private readonly User _user;

        public FrmChangePassword()
        {
            InitializeComponent();

            _user = CurrentUserUtil.User;

            buttonChange.Click += Change;
        }
        
        private void Change(object sender, EventArgs e)
        {
            var currentPassword = textBoxCurrentPwd.Text;
            var newPassword = textBoxNewPwd.Text;
            var confirmPassword = textBoxConfirmPwd.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show(@"New password and confirm password do not match.");
                return;
            }

            if (AuthHelper.ValidatePassword(_user.UserId, currentPassword, _user.UserType))
            {
                AuthHelper.UpdatePassword(_user.UserId, newPassword, _user.UserType);
                MessageBox.Show(@"Password updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show(@"Current password is incorrect.");
            }
        }
    }
}