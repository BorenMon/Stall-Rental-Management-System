using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    public class StaffPresenter
    {
        // Fields
        private readonly IStaffView _view;
        private readonly IStaffRepository _repository;
        private readonly BindingSource _staffsBindingSource;
        private IEnumerable<StaffModel> _staffList;

        // Constructor
        public StaffPresenter(IStaffView view, IStaffRepository repository)
        {
            _staffsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchStaff;
            _view.AddNewEvent += AddNewStaff;
            _view.EditEvent += LoadSelectedStaffToEdit;
            _view.DeleteEvent += DeleteSelectedStaff;
            _view.SaveEvent += SaveStaff;
            _view.CancelEvent += CancelAction;

            // Set staffs binding source
            _view.SetStaffListBindingSource(_staffsBindingSource);

            // Load staff list view
            LoadAllStaffList();

            // Show view
            _view.Show();
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
                StaffId = Convert.ToInt32(_view.StaffID),
                LastNameKh = _view.LastNameKH,
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
            _view.StaffID = "0";
            _view.LastNameKH = "";
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
            _view.StaffID = staff.StaffId.ToString();
            _view.LastNameKH = staff.LastNameKh;
            _view.IsEdit = true;
        }

        private void AddNewStaff(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }
    }
}
