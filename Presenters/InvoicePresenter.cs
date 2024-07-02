using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
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
            _view.AddNewEvent += AddNewInvoice;
            _view.SaveOrUpdateEvent += SaveOrUpdateInvoice;
            _view.ViewEvent += ViewInvoice;

            // Set binding source
            _view.SetListBindingSource(_bindingSource);
            
            _view.SetContractIdOnComboBox(GetAllContracts());

            // Load list view
            LoadAllInvoiceList();
        }

        private static IEnumerable<Contract> GetAllContracts()
        {
            return InvoiceRepository.GetAllContracts();
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
                InvoiceId = _view.InvoiceId,
                InvoiceNo = _view.InvoiceNo,
                IssuedDate = _view.IssuedDate,
                RentFee = _view.RentFee,
                ElectricityCost = _view.ElectricityCost,
                WaterCost = _view.WaterCost,
                TotalAmount = _view.TotalAmount,
                Status = _view.Status,
                ContractId = _view.ContractId,
                StaffId = _view.StaffId
            };
            
            try
            {
                ModelDataValidation.Validate(invoice);
                _repository.InsertOrUpdate(invoice);
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
            _view.InvoiceId = 0;
            _view.InvoiceNo = CodeGeneratorUtil.GenerateRandomCode(8);
            _view.IssuedDate = DateTime.Now.Date;
            _view.RentFee = 0;
            _view.ElectricityCost = 0;
            _view.WaterCost = 0;
            _view.TotalAmount = 0;
            _view.Status = InvoiceStatus.UNPAID;
            _view.ContractId = 0;
            _view.StaffId = CurrentUserUtil.User.UserId;
        }

        private void LoadSelectedInvoice()
        {
            var invoice = (InvoiceModel)_bindingSource.Current;
            _view.Invoice = invoice;
        
            _view.InvoiceId = invoice.InvoiceId;
            _view.InvoiceNo = invoice.InvoiceNo;
            _view.IssuedDate = invoice.IssuedDate;
            _view.RentFee = invoice.RentFee;
            _view.ElectricityCost = invoice.ElectricityCost;
            _view.WaterCost = invoice.WaterCost;
            _view.TotalAmount = invoice.TotalAmount;
            _view.Status = invoice.Status;
            _view.ContractId = invoice.ContractId;
            _view.StaffId = invoice.StaffId;
        }

        private void AddNewInvoice(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanViewFields();
        }
    }
}