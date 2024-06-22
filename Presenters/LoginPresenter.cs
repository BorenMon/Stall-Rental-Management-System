using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.Panel_Forms;


namespace Stall_Rental_Management_System.Presenters
{
    public class LoginPresenter
    {
        private readonly FrmLogin _view;
        private readonly AuthenticationService _authService;

        public LoginPresenter(FrmLogin view, AuthenticationService authService)
        {
            _view = view;
            _authService = authService;
        }

        public void Login()
        {
            var phoneNumber = _view.PhoneNumber;
            var password = _view.Password;
            var userType = _view.SelectedUserType;

            if (_authService.Login(phoneNumber, password, userType))
            {
                _view.ShowMessage("Login successful!");

                // Navigate to the next form based on user type
                Form nextForm = null;
                if (userType == UserType.SUPERMARKET_STAFF)
                {
                    nextForm = new FrmManagerPanel(_authService);
                }

                if (nextForm == null) return;
                nextForm.Show();
                _view.Hide();
                nextForm.FormClosed += (s, args) => _view.Close();
            }
            else
            {
                _view.ShowMessage("Invalid phone number or password.");
            }
        }
    }
}