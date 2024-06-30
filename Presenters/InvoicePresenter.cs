using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;


namespace Stall_Rental_Management_System.Presenters
{
    public class InvoicePresenter
    {
        // Fields
        private readonly FrmInvoice _view;
        private readonly InvoiceRepository _repository;
        private readonly BindingSource _bindingSource;
        private IEnumerable<InvoiceModel> _list;

        // Constructor
        public InvoicePresenter(FrmInvoice view, InvoiceRepository repository)
        {
            _bindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchInvoice;
            _view.UploadProfileEvent += UploadStaffProfile;
            _view.AddNewEvent += AddNewInvoice;
            _view.DeleteEvent += DeleteSelectedInvoice;
            _view.SaveOrUpdateEvent += SaveOrUpdateInvoice;
            _view.ViewEvent += ViewInvoice;

            // Set binding source
            _view.SetInvoiceListBindingSource(_bindingSource);

            // Load list view
            LoadAllInvoiceList();
        }

        private void ViewInvoice(object sender, EventArgs e)
        {
            _view.IsEdit = true;
            LoadSelectedInvoice();
        }

        private void LoadAllInvoiceList()
        {
            _list = _repository.GetAll();
            _bindingSource.DataSource = _list; // Set data source
        }
        private void SearchInvoice(object sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            _list = emptyValue==false ? _repository.GetByValue(this._view.SearchValue) : _repository.GetAll();
            _bindingSource.DataSource = _list;
        }

        private void SaveOrUpdateInvoice(object sender, EventArgs e)
        {
            var invoice = new InvoiceModel
            {
                // ProfileImageUrl = _view.CurrentProfileImageObjectName,
                // LastNameEn = _view.LastNameEn,
                // FirstNameEn = _view.FirstNameEn,
                // LastNameKh = _view.LastNameKh,
                // FirstNameKh = _view.FirstNameKh,
                // BirthDate = _view.BirthDate,
                // Gender = _view.Gender,
                // Email = _view.Email,
                // Position = _view.Position,
                // PhoneNumber = _view.PhoneNumber,
                // Password = _view.Password,
                // Address = _view.Address
            };
            try
            {
                ModelDataValidation.Validate(invoice);
                if (!int.TryParse(_view.StaffId, out var invoiceId))
                {
                    invoiceId = 0; // Set default value if parsing fails
                }
                _repository.InsertOrUpdate(invoice, invoiceId);
                _view.Message = _view.IsEdit ? "Invoice edited successfully" : "Invoice added successfully";

                _view.IsSuccessful = true;
                LoadAllInvoiceList();
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
            _view.CurrentProfileImageObjectName = null;
            _view.ProfileImageUrl = "";
            _view.LastNameEn = null;
            _view.FirstNameEn = null;
            _view.LastNameKh = null;
            _view.FirstNameKh = null;
            _view.BirthDate = DateTime.Now.Date;
            _view.Gender = Gender.FEMALE;
            _view.Email = null;
            _view.Position = StaffPosition.STAFF;
            _view.PhoneNumber = null;
            _view.Password = null;
            _view.Address = null;
        }

        private void DeleteSelectedInvoice(object sender, EventArgs e)
        {
            try
            {
                var invoice = (InvoiceModel)_bindingSource.Current;
                _repository.Delete(invoice);
                _view.IsSuccessful = true;
                _view.Message = "Invoice deleted successfully";
                LoadAllInvoiceList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void LoadSelectedInvoice()
        {
            var invoice = (InvoiceModel)_bindingSource.Current;
        
            _view.StaffId = invoice.StaffId.ToString();
            _view.ProfileImageUrl = invoice.ProfileImageUrl;
            _view.LastNameKh = invoice.LastNameKh;
            _view.FirstNameKh = invoice.FirstNameKh;
            _view.LastNameEn = invoice.LastNameEn;
            _view.FirstNameEn = invoice.FirstNameEn;
            _view.BirthDate = invoice.BirthDate;
            _view.Gender = invoice.Gender;
            _view.Email = invoice.Email;
            _view.Position = invoice.Position;
            _view.PhoneNumber = invoice.PhoneNumber;
            _view.Password = invoice.Password;
            _view.Address = invoice.Address;
        }

        private void AddNewInvoice(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanViewFields();
        }
    }
}
