using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Presenter
{
    public class StaffPresenter
    {
        // Fields
        private IStaffView view;
        private IStaffRepository repository;
        private BindingSource staffsBindingSource;
        private IEnumerable<StaffModel> staffList;

        // Constructor
        public StaffPresenter(IStaffView view, IStaffRepository repository)
        {
            this.staffsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Subscribe event handler methods to view events
            this.view.SearchEvent += SearchStaff;
            this.view.AddNewEvent += AddNewStaff;
            this.view.EditEvent += LoadSelectedStaffToEdit;
            this.view.DeleteEvent += DeleteSelectedStaff;
            this.view.SaveEvent += SaveStaff;
            this.view.CancelEvent += CancelAction;

            // Set staffs binding source
            this.view.SetStaffListBindingSource(staffsBindingSource);

            // Load staff list view
            loadAllStaffList();

            // Show view
            this.view.Show();
        }

        private void loadAllStaffList()
        {
            staffList = repository.GetAll();
            staffsBindingSource.DataSource = staffList; // Set data source
        }
        private void SearchStaff(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue==false) {
                staffList = repository.GetByValue(this.view.SearchValue);
            } else {
                staffList = repository.GetAll();
            }
            staffsBindingSource.DataSource = staffList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveStaff(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedStaff(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedStaffToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewStaff(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
