using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IAuthenticationService _authService;

        public LoginPresenter(ILoginView view, IAuthenticationService authService)
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
                var currentUser = _authService.CurrentUser;
                _view.ShowMessage("Login successful!");

                _view.Close();
            }
            else
            {
                _view.ShowMessage("Invalid phone number or password.");
            }
        }
    }
}