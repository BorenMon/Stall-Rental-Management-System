using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Services.Service_Interfaces;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        private readonly string _sqlConnectionString;
        private readonly IAuthenticationService _authenticationService;
        private readonly IAuthorizationService _authorizationService;

        public MainPresenter(IMainView mainView, string sqlConnectionString, IAuthenticationService authenticationService, IAuthorizationService authorizationService)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;
            _authenticationService = authenticationService;
            _authorizationService = authorizationService;
            _mainView.ShowStaffView += ShowStaffView;
            // _mainView.Load += OnLoad;
        }

        private void ShowStaffView(object sender, EventArgs e)
        {
            IStaffView view = FrmStaff.GetInstance();
            IStaffRepository repository = new StaffRepository(_sqlConnectionString);
            var staffPresenter = new StaffPresenter(view, repository);
        }
        private void OnLoad(object sender, EventArgs e)
        {
            if (!_authenticationService.IsAuthenticated)
            {
                _mainView.ShowLogin();
                return;
            }

            if (!_authorizationService.HasPermission("AccessMainView"))
            {
                _mainView.ShowMessage("Access denied!");
                _mainView.Close();
            }
        }
        
    }
}