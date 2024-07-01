using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.DesignHelpers;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmLogin : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;

        public FrmLogin(AuthenticationService authService)
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, authService);

            //comboBoxUserType.DataSource = EnumHelper.GetEnumDisplayNames<UserType>();
            //comboBoxUserType.DisplayMember = "Value";
            //comboBoxUserType.ValueMember = "Key";

            textBoxPhoneNumber.KeyPress += (sender, e) =>
            {
                var textBox = (TextBox)sender;
                PhoneNumberValidationHelper.ValidateKeypress(textBox, e);
            };
            textBoxPhoneNumber.TextChanged += (sender, e) =>
            {
                var textBox = (TextBox)sender;
                PhoneNumberValidationHelper.ValidatePaste(textBox);
            };
        }

        public string PhoneNumber => textBoxPhoneNumber.Text;
        public string Password => textBoxPassword.Text;
        //public UserType SelectedUserType => (UserType)comboBoxUserType.SelectedValue;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }
    }
}