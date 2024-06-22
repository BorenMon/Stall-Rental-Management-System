using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Services.Service_Interfaces;
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

            comboBoxUserType.DataSource = EnumHelper.GetEnumDisplayNames<UserType>();
            comboBoxUserType.DisplayMember = "Value";
            comboBoxUserType.ValueMember = "Key";

            textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
            textBoxPhoneNumber.TextChanged += textBoxPhoneNumber_TextChanged;
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"[^\d]");
            textBoxPhoneNumber.Text = regex.Replace(textBoxPhoneNumber.Text, ""); // Remove non-digit characters

            // If the text length exceeds 20 characters, truncate it
            if (textBoxPhoneNumber.Text.Length > 20)
            {
                textBoxPhoneNumber.Text = textBoxPhoneNumber.Text.Substring(0, 20);
            }

            // Set the cursor to the end of the text
            textBoxPhoneNumber.SelectionStart = textBoxPhoneNumber.Text.Length;
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Regular expression for digits only
            var regex = new Regex(@"^\d+$");

            // Check if the pressed key is a digit and if the length is less than 20
            if (!char.IsControl(e.KeyChar) && (!regex.IsMatch(e.KeyChar.ToString()) || textBoxPhoneNumber.Text.Length >= 20))
            {
                e.Handled = true; // Suppress the event
            }
        }

        public string PhoneNumber => textBoxPhoneNumber.Text;
        public string Password => textBoxPassword.Text;
        public UserType SelectedUserType => (UserType)comboBoxUserType.SelectedValue;

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