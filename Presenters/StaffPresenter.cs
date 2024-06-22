using Stall_Rental_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;

namespace Stall_Rental_Management_System.Presenters
{
    public class StaffPresenter
    {
        // Fields
        private readonly FrmStaff _view;
        private readonly IStaffRepository _repository;
        private readonly BindingSource _staffsBindingSource;
        private IEnumerable<StaffModel> _staffList;
        
        private readonly AuthenticationService _authService;

        // Constructor
        public StaffPresenter(FrmStaff view, IStaffRepository repository, AuthenticationService authService)
        {
            _staffsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;
            _authService = authService;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchStaff;
            _view.AddNewEvent += AddNewStaff;
            _view.EditEvent += LoadSelectedStaffToEdit;
            _view.DeleteEvent += DeleteSelectedStaff;
            _view.SaveEvent += SaveStaff;
            _view.CancelEvent += CancelAction;
            _view.BackToPanelEvent += BackToPanel;
            _view.LogoutEvent += Logout;

            // Set staffs binding source
            _view.SetStaffListBindingSource(_staffsBindingSource);

            // Load staff list view
            LoadAllStaffList();

            // Show view
            _view.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            _view.Message = "Logout successfully!";
            _authService.Logout();
        }

        private void BackToPanel(object sender, EventArgs e)
        {
            var currentUser = CurrentUserUtil.User;
            if (currentUser.UserType == UserType.SUPERMARKET_STAFF && currentUser.Position == StaffPosition.MANAGER) 
                ManagerNavigateHelper.NavigateToManagerPanel(_view, _authService);
        }

        private void LoadAllStaffList()
        {
            _staffList = _repository.GetAll();
            _staffsBindingSource.DataSource = _staffList; // Set data source
        }
        private void SearchStaff(object sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            _staffList = emptyValue==false ? _repository.GetByValue(this._view.SearchValue) : _repository.GetAll();
            _staffsBindingSource.DataSource = _staffList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveStaff(object sender, EventArgs e)
        {
            var model = new StaffModel
            {
                StaffId = Convert.ToInt32(_view.StaffId),
                LastNameKh = _view.LastNameKh,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_view.IsEdit) // Edit model
                {
                    _repository.Edit(model);
                    _view.Message = "Staff edited successfully";
                }
                else // Add new model
                {
                    _repository.Add(model);
                    _view.Message = "Staff added successfully";
                }

                _view.IsSuccessful = true;
                LoadAllStaffList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _view.StaffId = "Auto Generate";
            _view.LastNameEn = "";
            _view.FirstNameEn = "";
            _view.LastNameKh = "";
            _view.FirstNameKh = "";
            _view.BirthDate = DateTime.Now.Date;
            _view.Email = "";
            _view.Position = StaffPosition.STAFF;
            _view.PhoneNumber = "";
            _view.Password = "";
            _view.Address = "";
        }

        private void DeleteSelectedStaff(object sender, EventArgs e)
        {
            try
            {
                var staff = (StaffModel)_staffsBindingSource.Current;
                _repository.Delete(staff);
                _view.IsSuccessful = true;
                _view.Message = "Staff deleted successfully";
                LoadAllStaffList();
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error occured, could not delete staff";
            }
        }

        private void LoadSelectedStaffToEdit(object sender, EventArgs e)
        {
            var staff = (StaffModel)_staffsBindingSource.Current;
            
            _view.StaffId = staff.StaffId.ToString();
            _view.LastNameKh = staff.LastNameKh;
            _view.FirstNameKh = staff.FirstNameKh;
            _view.LastNameEn = staff.LastNameEn;
            _view.FirstNameEn = staff.FirstNameEn;
            _view.BirthDate = staff.BirthDate;
            _view.Gender = staff.Gender;
            _view.Email = staff.Email;
            _view.Position = staff.Position;
            _view.PhoneNumber = staff.PhoneNumber;
            _view.Password = staff.Password;
            _view.Address = staff.Address;
            
            _view.IsEdit = true;
        }

        private void AddNewStaff(object sender, EventArgs e)
        {
            CleanViewFields();
            _view.IsEdit = false;
        }
    }
}
