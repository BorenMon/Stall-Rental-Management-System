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
    internal class ContractPresenterForStaff
    {
        // Fields
        private readonly IContractViewForStaff _viewForStaff;
        private readonly IContractRepository _contractRepository;
        private BindingSource _contractBindingSource;
        private IEnumerable<ContractModel> _contractList;

        public ContractPresenterForStaff(IContractViewForStaff viewForStaff, IContractRepository contractRepository)
        {
            _contractBindingSource = new BindingSource();   
            _viewForStaff = viewForStaff;
            _contractRepository = contractRepository;
            //

            _viewForStaff.SearchContract += SearchContractById;
            _viewForStaff.SaveContract += SaveContract;
            _viewForStaff.UpdateContract += UpdateContract;
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

        public ContractPresenterForStaff(ContractRepository contractRepository) {
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
            if (_viewForStaff.SelectedFilePath != null)
            {
                UploadFileToMinIo(this._viewForStaff.SelectedFilePath, _viewForStaff.FileName);
                contract.FileUrl = await GetGenerateUrlFromMinIo(_viewForStaff.FileName);
            }
            
            try
            {
                ModelDataValidation.Validate(contract);
                _contractRepository.Add(contract);
                
                LoadAllContractData();
                
                _viewForStaff.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _viewForStaff.IsSuccessful = false;
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

                contract.ContractId = int.Parse(_viewForStaff.ContractId);
                if (_viewForStaff.SelectedFilePath != null)
                {
                    UploadFileToMinIo(_viewForStaff.SelectedFilePath, _viewForStaff.FileName);
                    contract.FileUrl = await GetGenerateUrlFromMinIo(_viewForStaff.FileName);
                }
                else
                {
                    contract.FileUrl = _viewForStaff.FileUrl;
                }
                _contractRepository.Update(contract);
                LoadAllContractData();
                _viewForStaff.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _viewForStaff.IsSuccessful = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchContractById(object sender, EventArgs e)
        {
            _contractList = _contractRepository.GetByID(this._viewForStaff.ContractId);
            _contractBindingSource = new BindingSource();
            _contractBindingSource.DataSource = _contractList;
            _viewForStaff.SetContractBindingSource(_contractBindingSource);
            //MessageBox.Show("Number of Search Found: " + contractList.Count().ToString());
        }
        // constructor
        private ContractModel SetContractModelValue()
        {
            var contract = new ContractModel();
            if (_viewForStaff.SelectedFilePath == null)
            {
                contract.FileUrl = _viewForStaff.FileUrl ?? "";
            }

            contract.Code = _viewForStaff.Code;
            contract.Status = _viewForStaff.Status;
            contract.StartDate = _viewForStaff.StartDate;
            contract.EndDate = _viewForStaff.EndDate;
            contract.VendorId = _viewForStaff.VendorId;
            contract.StallId = _viewForStaff.StallId;
            contract.StaffId = _viewForStaff.StaffId;
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
