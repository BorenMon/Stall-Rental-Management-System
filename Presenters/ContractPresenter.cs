using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    internal class ContractPresenter
    {
        // Fields
        private readonly IContractView _view;
        private readonly IContractRepository _contractRepository;
        private BindingSource _contractBindingSource;
        private IEnumerable<ContractModel> _contractList;

        public ContractPresenter(IContractView view, IContractRepository contractRepository)
        {
            _contractBindingSource = new BindingSource();   
            _view = view;
            _contractRepository = contractRepository;
            //

            _view.SearchContract += SearchContractById;
            _view.AddNewContract += AddNewContract;
            _view.SaveContract += SaveContract;
            _view.UpdateContract += UpdateContract;
            _view.ViewEvent += ViewContract;

            //get all contracts
            _view.SetContractBindingSource(_contractBindingSource);
            
            // get all stall ids
            _view.SetStallIdOnComboBox(GetAllStallIDs());
            // get all vendor ids
            _view.SetVendorIdOnComboBox(GetAllVendorIDs());
            
            LoadAllContractData();
        }

        private void ViewContract(object sender, EventArgs e)
        {
            LoadSelectedContract();
        }

        private void LoadSelectedContract()
        {
            var contract = (ContractModel)_contractBindingSource.Current;

            _view.ContractId = contract.ContractId.ToString();
            _view.FileUrl = contract.FileUrl;
            _view.Code = contract.Code;
            _view.Status = contract.Status;
            _view.StartDate = contract.StartDate;
            _view.EndDate = contract.EndDate;
            _view.StaffId = contract.StaffId;
            _view.VendorId = contract.VendorId;
            _view.StallId = contract.StallId;

            // ContractId = contract.ContractId.ToString();
            // FileUrl = contract.FileUrl;
            // contractCodeText.Text = contract.Code;
            // contractStatusComboBox.SelectedValue = contract.Status;
            // startDateContract.Value = contract.StartDate;
            // endDateConstract.Value = contract.EndDate;
            // contractStallIDComboBox.Text = contract.StallId.ToString();
            // contractVendorIDComboBox.Text = contract.VendorId.ToString();
            // textBoxStaffId.Text = contract.StaffId.ToString();
        }

        public ContractPresenter(ContractRepository contractRepository) {
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

        private async void SaveContract(object sender, EventArgs e)
        {
            var contract = SetContractModelValue();
            if (_view.SelectedFilePath != null)
            {
                UploadFileToMinIo(this._view.SelectedFilePath, _view.FileName);
                contract.FileUrl = await GetGenerateUrlFromMinIo(_view.FileName);
            }
            
            try
            {
                ModelDataValidation.Validate(contract);
                _contractRepository.Add(contract);
                
                LoadAllContractData();
                
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                MessageBox.Show(ex.Message);
            }
        }
        
        // methods
        private void LoadAllContractData()
        {
            _contractList = _contractRepository.GetAll();
            _contractBindingSource.DataSource = _contractList;
        }

        private async void UpdateContract(object sender, EventArgs e)
        {
            var contract = SetContractModelValue();
            
            try
            {
                ModelDataValidation.Validate(contract);

                contract.ContractId = int.Parse(_view.ContractId);
                if (_view.SelectedFilePath != null)
                {
                    UploadFileToMinIo(_view.SelectedFilePath, _view.FileName);
                    contract.FileUrl = await GetGenerateUrlFromMinIo(_view.FileName);
                }
                else
                {
                    contract.FileUrl = _view.FileUrl;
                }
                _contractRepository.Update(contract);
                LoadAllContractData();
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewContract(object sender, EventArgs e)
        {
 
        }

        private void SearchContractById(object sender, EventArgs e)
        {
            _contractList = _contractRepository.GetByID(this._view.ContractId);
            _contractBindingSource = new BindingSource();
            _contractBindingSource.DataSource = _contractList;
            _view.SetContractBindingSource(_contractBindingSource);
            //MessageBox.Show("Number of Search Found: " + contractList.Count().ToString());
        }
        // constructor
        private ContractModel SetContractModelValue()
        {
            var contract = new ContractModel();
            if (_view.SelectedFilePath == null)
            {
                contract.FileUrl = _view.FileUrl ?? "";
            }

            contract.Code = _view.Code;
            contract.Status = _view.Status;
            contract.StartDate = _view.StartDate;
            contract.EndDate = _view.EndDate;
            contract.VendorId = _view.VendorId;
            contract.StallId = _view.StallId;
            contract.StaffId = _view.StaffId;
            return contract;
        }
        private static async void UploadFileToMinIo(string selectedFilePath,string fileName)
        {

            const string bucketName = "srms";
            try
            {
                await MinIoUtil
                    .GetMinioClient()
                    .PutObjectAsync(new PutObjectArgs()
                    .WithBucket(bucketName)
                    .WithObject(fileName)
                    .WithFileName(selectedFilePath));
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private static async Task<string> GetGenerateUrlFromMinIo(string fileName)
        {

            const string bucketName = "srms";
            // get Url file from minio
            // Generate the presigned URL with the maximum allowed expiration time (7 days)
            var url = await MinIoUtil.GetMinioClient()
                .PresignedGetObjectAsync(new PresignedGetObjectArgs()
                .WithBucket(bucketName)
                .WithObject(fileName)
                .WithExpiry(604800));// 7 days in seconds
            return url;
        }
    }
}
