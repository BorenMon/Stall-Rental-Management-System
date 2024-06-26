using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Models;


namespace Stall_Rental_Management_System.Presenters
{
    public class StallPresenter
    {
        // Fields
        private readonly FrmStall _view;
        private readonly StallRepository _repository;
        private readonly BindingSource _stallsBindingSource;
        private IEnumerable<StallModel> _stallList;

        // Constructor
        public StallPresenter(FrmStall view, StallRepository repository)
        {
            _stallsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchStall;
            _view.AddNewEvent += AddNewStall;
            _view.DeleteEvent += DeleteSelectedStall;
            _view.SaveOrUpdateEvent += SaveOrUpdateStall;
            _view.ViewEvent += ViewStall;

            // Set staffs binding source
            _view.SetStallListBindingSource(_stallsBindingSource);

            // Load staff list view
            LoadAllStalls();
        }

        private void ViewStall(object sender, EventArgs e)
        {
            _view.IsEdit = true;
            LoadSelectedStall();
        }

        private void LoadAllStalls()
        {
            _stallList = _repository.GetAll();
            _stallsBindingSource.DataSource = _stallList; // Set data source
        }
        
        private void SearchStall(object sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            _stallList = emptyValue==false ? _repository.GetByCode(this._view.SearchValue) : _repository.GetAll();
            _stallsBindingSource.DataSource = _stallList;
        }

        private void SaveOrUpdateStall(object sender, EventArgs e)
        {
            var stall = new StallModel
            {
                Code = _view.Code,
                Status = _view.Status,
                Type = _view.Type,
                Size = _view.StallSize,
                MonthlyFee = _view.MonthlyFee,
                Location = _view.StallLocation
            };
            try
            {
                ModelDataValidation.Validate(stall);
                _repository.InsertOrUpdate(stall, 1);
                _view.Message = _view.IsEdit ? "Stall edited successfully" : "Stall added successfully";
                
                _view.IsSuccessful = true;
                LoadAllStalls();
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
            _view.StallId = 0;
            _view.Code = "";
            _view.Status = StallStatus.AVAILABLE;
            _view.Type = string.Empty;
            _view.StallSize = 0;
            _view.MonthlyFee = 0;
            _view.StallLocation = "";
        }

        private void DeleteSelectedStall(object sender, EventArgs e)
        {
            try
            {
                var stall = (StallModel)_stallsBindingSource.Current;
                _repository.Delete(stall);
                _view.IsSuccessful = true;
                _view.Message = "Staff deleted successfully";
                LoadAllStalls();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void LoadSelectedStall()
        {
            var stall = (StallModel)_stallsBindingSource.Current;

            _view.StallId = stall.StallId;
            _view.Code = stall.Code;
            _view.Status = stall.Status;
            _view.Type = stall.Type;
            _view.StallSize = stall.Size;
            _view.MonthlyFee = stall.MonthlyFee;
            _view.StallLocation = stall.Location;
        }

        private void AddNewStall(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanViewFields();
        }
    }
}
