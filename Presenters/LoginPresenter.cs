using System;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IAuthenticationService _authenticationService;
        
        public LoginPresenter(ILoginView view, IAuthenticationService authenticationService)
        {
            _view = view;
            _authenticationService = authenticationService;
            _view.Login += OnLogin;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            var phoneNumber = _view.PhoneNumber;
            var password = _view.Password;
            if (_authenticationService.Login(phoneNumber, password))
            {
                _view.ShowMessage("Login successful!");
                // Proceed to the next view or main application
            }
            else
            {
                _view.ShowMessage("Login failed!");
            }
        }
    }
}