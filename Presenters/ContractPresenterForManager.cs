using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    internal class ContractPresenterForManager
    {
        // Fields
        private readonly IContractViewForManager _viewForStaff;
        private readonly IContractRepository _contractRepository;
        private BindingSource _contractBindingSource;
        private IEnumerable<ContractModel> _contractList;

        public ContractPresenterForManager(IContractViewForManager viewForStaff, IContractRepository contractRepository)
        {
            _contractBindingSource = new BindingSource();   
            _viewForStaff = viewForStaff;
            _contractRepository = contractRepository;
            //

            _viewForStaff.SearchContract += SearchContractById;
            _viewForStaff.ViewEvent += ViewForStaffContract;

            //get all contracts
            _viewForStaff.SetContractBindingSource(_contractBindingSource);
            
            // get all stall ids
            _viewForStaff.SetStallIdOnComboBox(GetAllStallIDs());
            // get all vendor ids
            _viewForStaff.SetVendorIdOnComboBox(GetAllVendorIDs());
            
            LoadAllContractData();
        }

        private void ViewForStaffContract(object sender, EventArgs e)
        {
            LoadSelectedContract();
        }

        private void LoadSelectedContract()
        {
            var contract = (ContractModel)_contractBindingSource.Current;

            _viewForStaff.ContractId = contract.ContractId.ToString();
            _viewForStaff.FileUrl = contract.FileUrl;
            _viewForStaff.Code = contract.Code;
            _viewForStaff.Status = contract.Status;
            _viewForStaff.StartDate = contract.StartDate;
            _viewForStaff.EndDate = contract.EndDate;
            _viewForStaff.StaffId = contract.StaffId;
            _viewForStaff.VendorId = contract.VendorId;
            _viewForStaff.StallId = contract.StallId;
        }

        public ContractPresenterForManager(ContractRepository contractRepository) {
            _contractRepository = contractRepository;
        }
        private IEnumerable<int> GetAllVendorIDs()
        {
            return _contractRepository.GetAllVendorID();
        }

        private IEnumerable<int> GetAllStallIDs()
        {
            return _contractRepository.GetAllStallID();
        }
        
        // methods
        private void LoadAllContractData()
        {
            _contractList = _contractRepository.GetAll();
            _contractBindingSource.DataSource = _contractList;
        }

        private void SearchContractById(object sender, EventArgs e)
        {
            _contractList = _contractRepository.GetByID(this._viewForStaff.ContractId);
            _contractBindingSource = new BindingSource();
            _contractBindingSource.DataSource = _contractList;
            _viewForStaff.SetContractBindingSource(_contractBindingSource);
        }
    }
}
